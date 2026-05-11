using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Engine;

namespace NeverEnd
{
    public partial class NeverEnd : Form
    {
        private const string PlayerDataFileName = "PlayerData.xml";
        private const int PotionPrice = 8;

        private Player _player;
        private Monster _currentMonster;
        private bool _gameCompleted;

        public NeverEnd()
        {
            InitializeComponent();
            ConfigureTables();
            LoadPlayer();
            MoveTo(_player.CurrentLocation);
            AppendMessage("Добро пожаловать в Never End. Следы во дворе ведут на север.");
        }

        private void LoadPlayer()
        {
            if (File.Exists(PlayerDataFileName))
            {
                _player = Player.CreatePlayerFromXmlString(File.ReadAllText(PlayerDataFileName));
            }
            else
            {
                _player = Player.CreateDefaultPlayer();
            }

            _gameCompleted = _player.CompletedThisQuest(World.QuestByID(World.QUEST_ID_FIND_WIFE));
        }

        private void SavePlayer()
        {
            File.WriteAllText(PlayerDataFileName, _player.ToXmlString());
        }

        private void ConfigureTables()
        {
            dgvInventory.ColumnCount = 2;
            dgvInventory.Columns[0].Name = "Предмет";
            dgvInventory.Columns[0].Width = 220;
            dgvInventory.Columns[1].Name = "Кол-во";
            dgvInventory.Columns[1].Width = 80;

            dgvQuests.ColumnCount = 2;
            dgvQuests.Columns[0].Name = "Квест";
            dgvQuests.Columns[0].Width = 220;
            dgvQuests.Columns[1].Name = "Статус";
            dgvQuests.Columns[1].Width = 80;
        }

        private void btnNorth_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationToNorth);
        }

        private void btnEast_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationToEast);
        }

        private void btnWest_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationToWest);
        }

        private void btnSouth_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationToSouth);
        }

        private void btnUseWeapon_Click(object sender, EventArgs e)
        {
            if (_currentMonster == null)
            {
                AppendMessage("Здесь не с кем сражаться.");
                return;
            }

            if (cboWeapons.SelectedItem is not Weapon currentWeapon)
            {
                AppendMessage("Выберите оружие перед атакой.");
                return;
            }

            int damageToMonster = RandomNumberGenerator.NumberBetween(currentWeapon.MinimumDamage, currentWeapon.MaximumDamage);
            _currentMonster.CurrentHitPoints -= damageToMonster;
            AppendMessage("Вы нанесли " + damageToMonster + " урона: " + _currentMonster.Name + ".");

            if (_currentMonster.CurrentHitPoints <= 0)
            {
                DefeatMonster();
                return;
            }

            MonsterAttacksPlayer();
            RefreshGameState();
            SavePlayer();
        }

        private void btnUsePotion_Click(object sender, EventArgs e)
        {
            if (cboPotions.SelectedItem is not HealingPotion potion)
            {
                AppendMessage("У вас нет зелья для использования.");
                return;
            }

            _player.CurrentHitPoints = Math.Min(_player.MaximumHitPoints, _player.CurrentHitPoints + potion.AmountToHeal);
            _player.RemoveItemFromInventory(potion);
            AppendMessage("Вы выпили " + potion.Name + " и восстановили " + potion.AmountToHeal + " здоровья.");

            if (_currentMonster != null)
            {
                MonsterAttacksPlayer();
            }

            RefreshGameState();
            SavePlayer();
        }

        private void btnBuyPotion_Click(object sender, EventArgs e)
        {
            if (_player.CurrentLocation.ID != World.LOCATION_ID_SHOP)
            {
                return;
            }

            if (_player.Gold < PotionPrice)
            {
                AppendMessage("Торговец качает головой: нужно " + PotionPrice + " золота за зелье.");
                return;
            }

            _player.Gold -= PotionPrice;
            _player.AddItemToInventory(World.ItemByID(World.ITEM_ID_HEALING_POTION));
            AppendMessage("Вы купили лечебное зелье.");
            RefreshGameState();
            SavePlayer();
        }

        private void btnSaveGame_Click(object sender, EventArgs e)
        {
            SavePlayer();
            AppendMessage("Игра сохранена.");
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Начать новую игру? Текущее сохранение будет перезаписано.",
                "Новая игра",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            _player = Player.CreateDefaultPlayer();
            _currentMonster = null;
            _gameCompleted = false;
            rtbMessages.Clear();
            MoveTo(_player.CurrentLocation);
            AppendMessage("Новая игра началась. Во дворе ждут следы.");
            SavePlayer();
        }

        private void MoveTo(Location newLocation)
        {
            if (newLocation == null)
            {
                return;
            }

            if (!_player.HasRequiredItemToEnterThisLocation(newLocation))
            {
                AppendMessage("Нужен предмет: " + newLocation.ItemRequiredToEnter.Name + ".");
                return;
            }

            _player.CurrentLocation = newLocation;

            if (newLocation.RestoresHitPoints)
            {
                _player.CurrentHitPoints = _player.MaximumHitPoints;
                AppendMessage("Дома спокойно. Здоровье восстановлено.");
            }

            UpdateLocationImage(newLocation.ImageName);
            UpdateNavigationButtons(newLocation);
            UpdateLocationText(newLocation);
            HandleQuestAtLocation(newLocation);
            SpawnMonsterAtLocation(newLocation);
            RefreshGameState();
            SavePlayer();
        }

        private void HandleQuestAtLocation(Location location)
        {
            Quest quest = location.QuestAvailableHere;

            if (quest == null)
            {
                return;
            }

            bool playerAlreadyHasQuest = _player.HasThisQuest(quest);
            bool playerAlreadyCompletedQuest = _player.CompletedThisQuest(quest);

            if (!playerAlreadyHasQuest)
            {
                _player.Quests.Add(new PlayerQuest(quest));
                AppendMessage("Новый квест: " + quest.Name + ".");
                AppendMessage(quest.Description);
                AppendQuestRequirements(quest);
                return;
            }

            if (playerAlreadyCompletedQuest)
            {
                return;
            }

            if (!_player.HasAllQuestCompletionItems(quest))
            {
                AppendMessage("Квест активен: " + quest.Name + ".");
                AppendQuestProgress(quest);
                return;
            }

            CompleteQuest(quest);
        }

        private void CompleteQuest(Quest quest)
        {
            _player.RemoveQuestCompletionItems(quest);
            _player.ExperiencePoints += quest.RewardExperiencePoints;
            _player.Gold += quest.RewardGold;

            if (quest.RewardItem != null)
            {
                _player.AddItemToInventory(quest.RewardItem);
            }

            _player.MarkQuestCompleted(quest);
            AppendMessage("Квест выполнен: " + quest.Name + ".");
            AppendMessage("Награда: " + quest.RewardExperiencePoints + " опыта, " + quest.RewardGold + " золота" +
                (quest.RewardItem == null ? "." : ", " + quest.RewardItem.Name + "."));

            if (quest.ID == World.QUEST_ID_FIND_WIFE)
            {
                CompleteGame();
            }
        }

        private void CompleteGame()
        {
            _gameCompleted = true;
            _currentMonster = null;
            AppendMessage("");
            AppendMessage("Финал: вы нашли след Анны и вернулись домой с ее кольцом.");
            AppendMessage("История Never End завершена. Можно начать новую игру или продолжить гулять по миру.");
            MessageBox.Show("Вы прошли Never End!", "Победа", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SpawnMonsterAtLocation(Location location)
        {
            if (_gameCompleted || location.MonsterLivingHere == null)
            {
                _currentMonster = null;
                return;
            }

            Monster standardMonster = World.MonsterByID(location.MonsterLivingHere.ID);
            _currentMonster = new Monster(
                standardMonster.ID,
                standardMonster.Name,
                standardMonster.MaximumDamage,
                standardMonster.RewardExperiencePoints,
                standardMonster.RewardGold,
                standardMonster.CurrentHitPoints,
                standardMonster.MaximumHitPoints);

            foreach (LootItem lootItem in standardMonster.LootTable)
            {
                _currentMonster.LootTable.Add(lootItem);
            }

            AppendMessage("Вы видите врага: " + _currentMonster.Name + ".");
        }

        private void DefeatMonster()
        {
            AppendMessage("Вы победили: " + _currentMonster.Name + ".");
            _player.ExperiencePoints += _currentMonster.RewardExperiencePoints;
            _player.Gold += _currentMonster.RewardGold;
            AppendMessage("Получено: " + _currentMonster.RewardExperiencePoints + " опыта и " + _currentMonster.RewardGold + " золота.");

            foreach (InventoryItem item in RollLoot(_currentMonster))
            {
                _player.AddItemToInventory(item.Details);
                AppendMessage("Добыча: " + item.Details.Name + ".");
            }

            _currentMonster = null;
            RefreshGameState();
            SavePlayer();
        }

        private static List<InventoryItem> RollLoot(Monster monster)
        {
            List<InventoryItem> lootedItems = new List<InventoryItem>();

            foreach (LootItem lootItem in monster.LootTable)
            {
                if (RandomNumberGenerator.NumberBetween(1, 100) <= lootItem.DropPercentage)
                {
                    lootedItems.Add(new InventoryItem(lootItem.Details, 1));
                }
            }

            if (lootedItems.Count == 0)
            {
                foreach (LootItem lootItem in monster.LootTable.Where(item => item.IsDefaultItem))
                {
                    lootedItems.Add(new InventoryItem(lootItem.Details, 1));
                }
            }

            return lootedItems;
        }

        private void MonsterAttacksPlayer()
        {
            int damageToPlayer = RandomNumberGenerator.NumberBetween(0, _currentMonster.MaximumDamage);
            _player.CurrentHitPoints -= damageToPlayer;
            AppendMessage(_currentMonster.Name + " наносит вам " + damageToPlayer + " урона.");

            if (_player.CurrentHitPoints > 0)
            {
                return;
            }

            AppendMessage("Вы потеряли сознание и очнулись дома.");
            _currentMonster = null;
            _player.CurrentHitPoints = 1;
            MoveTo(World.LocationByID(World.LOCATION_ID_HOME));
        }

        private void RefreshGameState()
        {
            UpdatePlayerStats();
            UpdateInventoryListInUI();
            UpdateQuestListInUI();
            UpdateWeaponListInUI();
            UpdatePotionListInUI();
            UpdateCombatControls();
            UpdateGoalText();
        }

        private void UpdatePlayerStats()
        {
            lblHitPoints.Text = _player.CurrentHitPoints + " / " + _player.MaximumHitPoints;
            lblGold.Text = _player.Gold.ToString();
            lblExperience.Text = _player.ExperiencePoints.ToString();
            lblLevel.Text = _player.Level.ToString();
        }

        private void UpdateInventoryListInUI()
        {
            dgvInventory.Rows.Clear();

            foreach (InventoryItem inventoryItem in _player.Inventory.Where(item => item.Quantity > 0))
            {
                dgvInventory.Rows.Add(inventoryItem.Details.Name, inventoryItem.Quantity.ToString());
            }
        }

        private void UpdateQuestListInUI()
        {
            dgvQuests.Rows.Clear();

            foreach (PlayerQuest playerQuest in _player.Quests)
            {
                dgvQuests.Rows.Add(playerQuest.Details.Name, playerQuest.IsCompleted ? "Готово" : "В работе");
            }
        }

        private void UpdateWeaponListInUI()
        {
            List<Weapon> weapons = _player.Inventory
                .Where(item => item.Quantity > 0)
                .Select(item => item.Details)
                .OfType<Weapon>()
                .ToList();

            cboWeapons.SelectedIndexChanged -= cboWeapons_SelectedIndexChanged;
            cboWeapons.DataSource = weapons;
            cboWeapons.DisplayMember = "Name";
            cboWeapons.ValueMember = "ID";

            if (weapons.Count > 0)
            {
                cboWeapons.SelectedItem = _player.CurrentWeapon != null && weapons.Any(weapon => weapon.ID == _player.CurrentWeapon.ID)
                    ? weapons.First(weapon => weapon.ID == _player.CurrentWeapon.ID)
                    : weapons[0];
                _player.CurrentWeapon = (Weapon)cboWeapons.SelectedItem;
            }

            cboWeapons.SelectedIndexChanged += cboWeapons_SelectedIndexChanged;
        }

        private void UpdatePotionListInUI()
        {
            List<HealingPotion> healingPotions = _player.Inventory
                .Where(item => item.Quantity > 0)
                .Select(item => item.Details)
                .OfType<HealingPotion>()
                .ToList();

            cboPotions.DataSource = healingPotions;
            cboPotions.DisplayMember = "Name";
            cboPotions.ValueMember = "ID";
        }

        private void UpdateCombatControls()
        {
            bool hasMonster = _currentMonster != null;
            bool hasWeapon = cboWeapons.Items.Count > 0;
            bool hasPotion = cboPotions.Items.Count > 0;

            lblMonster.Text = hasMonster
                ? "Враг: " + _currentMonster.Name + " (" + _currentMonster.CurrentHitPoints + "/" + _currentMonster.MaximumHitPoints + " HP)"
                : "Врагов рядом нет.";

            cboWeapons.Enabled = hasMonster && hasWeapon;
            btnUseWeapon.Enabled = hasMonster && hasWeapon;
            cboPotions.Enabled = hasPotion;
            btnUsePotion.Enabled = hasPotion;
            btnBuyPotion.Visible = _player.CurrentLocation.ID == World.LOCATION_ID_SHOP;
        }

        private void UpdateGoalText()
        {
            if (_gameCompleted)
            {
                lblGoal.Text = "Цель выполнена: Анна найдена. Можно начать новую игру.";
                return;
            }

            if (_player.HasItem(World.ItemByID(World.ITEM_ID_GOLD_RING)))
            {
                lblGoal.Text = "Цель: вернитесь во двор с кольцом Анны.";
                return;
            }

            if (!_player.HasItem(World.ItemByID(World.ITEM_ID_ADVENTURER_PASS)))
            {
                lblGoal.Text = "Цель: помогите фермеру и получите пропуск охраны.";
                return;
            }

            lblGoal.Text = "Цель: пройдите за мост и найдите след Анны.";
        }

        private void UpdateNavigationButtons(Location location)
        {
            btnNorth.Visible = location.LocationToNorth != null;
            btnEast.Visible = location.LocationToEast != null;
            btnSouth.Visible = location.LocationToSouth != null;
            btnWest.Visible = location.LocationToWest != null;
        }

        private void UpdateLocationText(Location location)
        {
            rtbLocation.Text = location.Name + Environment.NewLine + Environment.NewLine + location.Description;
        }

        private void UpdateLocationImage(string imageName)
        {
            Image nextImage = ImageAssets.LoadImage(imageName);

            if (nextImage == null)
            {
                nextImage = ImageAssets.LoadImage("pichome.jpg");
            }

            Image previousImage = picloc.Image;
            picloc.Image = nextImage;
            previousImage?.Dispose();
        }

        private void AppendQuestRequirements(Quest quest)
        {
            foreach (QuestCompletionItem item in quest.QuestCompletionItems)
            {
                AppendMessage("Нужно: " + item.Quantity + " x " + item.Details.Name + ".");
            }
        }

        private void AppendQuestProgress(Quest quest)
        {
            foreach (QuestCompletionItem item in quest.QuestCompletionItems)
            {
                InventoryItem inventoryItem = _player.Inventory.SingleOrDefault(ii => ii.Details.ID == item.Details.ID);
                int currentQuantity = inventoryItem == null ? 0 : inventoryItem.Quantity;
                AppendMessage(item.Details.Name + ": " + currentQuantity + " / " + item.Quantity + ".");
            }
        }

        private void AppendMessage(string message)
        {
            rtbMessages.AppendText(message + Environment.NewLine);
        }

        private void cboWeapons_SelectedIndexChanged(object sender, EventArgs e)
        {
            _player.CurrentWeapon = (Weapon)cboWeapons.SelectedItem;
        }

        private void cboPotions_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void rtbMessages_TextChanged(object sender, EventArgs e)
        {
            rtbMessages.SelectionStart = rtbMessages.Text.Length;
            rtbMessages.ScrollToCaret();
        }

        private void NeverEnd_FormClosing(object sender, FormClosingEventArgs e)
        {
            SavePlayer();
        }
    }
}
