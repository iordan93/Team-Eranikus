using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorldOfASCIITanks.GameObjects.World.Items;
using WorldOfASCIITanks.GameObjects.World.Movable;
using WorldOfASCIITanks.Rendering;
using WorldOfASCIITanks;
using System.Security.Cryptography;

namespace WorldOfAsciiTanksWForms
{
    public partial class BattleController : Form
    {
        private MainCharacter _player;
        private Opponent _opponent;
        public BattleController()
        {
            InitializeComponent();

            _player = new MainCharacter(new MatrixCoords(1, 1), new char[1, 1] { { '*' } }, 20, 80, 1, 10, 1, null);
            //_player = hero;
            // lblName.Text = _player.Name.ToString(); +Name??!?!
            lblLevel.Text = _player.Level.ToString();
            lblHitPoints.Text = _player.Health.ToString();
            lblManaPoints.Text = _player.ManaPoints.ToString();
            lblExperience.Text = _player.Experience.ToString();
        }
  //*/   private void UpdateWeaponListInUI()
  //      {
  //          List<Weapon> weapons = new List<Weapon>();

  //          foreach (InventoryItem inventoryItem in _player.Inventory)
  //          {
  //              if (inventoryItem.Details is Weapon)
  //              {
  //                  if (inventoryItem.Quantity > 0)
  //                  {
  //                      weapons.Add((Weapon)inventoryItem.Details);
  //                  }
  //              }
  //          }

  //          if (weapons.Count == 0)
  //          {
  //              // The player doesn't have any weapons, so hide the weapon combo-box and "Use" button
  //              cboWeapons.Visible = false;
  //              btnUseWeapon.Visible = false;
  //          }
  //          else
  //          {
  //              cboWeapons.DataSource = weapons;
  //              cboWeapons.DisplayMember = "Name";
  //              cboWeapons.ValueMember = "ID";

  //              cboWeapons.SelectedIndex = 0;
  //          }
  //      }

  //      private void UpdatePotionListInUI()
  //      {
  //          List<HealingPotion> healingPotions = new List<HealingPotion>();

  //          foreach (InventoryItem inventoryItem in _player.Inventory)
  //          {
  //              if (inventoryItem.Details is HealingPotion)
  //              {
  //                  if (inventoryItem.Quantity > 0)
  //                  {
  //                      healingPotions.Add((HealingPotion)inventoryItem.Details);
  //                  }
  //              }
  //          }

  //          if (healingPotions.Count == 0)
  //          {
  //              // The player doesn't have any potions, so hide the potion combo-box and "Use" button
  //              cboPotions.Visible = false;
  //              btnUsePotion.Visible = false;
  //          }
  //          else
  //          {
  //              cboPotions.DataSource = healingPotions;
  //              cboPotions.DisplayMember = "Name";
  //              cboPotions.ValueMember = "ID";

  //              cboPotions.SelectedIndex = 0;
  //          }
  //      }

  //      private void btnUseWeapon_Click(object sender, EventArgs e)
  //      {
  //          // Get the currently selected weapon from the cboWeapons ComboBox
  //          Weapon currentWeapon = (Weapon)cboWeapons.SelectedItem;

  //          // Determine the amount of damage to do to the monster
  //          int damageToMonster = RandomNumberGenerator.NumberBetween(currentWeapon.MinimumDamage, currentWeapon.MaximumDamage);

  //          // Apply the damage to the monster's CurrentHitPoints
  //          _currentMonster.CurrentHitPoints -= damageToMonster;

  //          // Display message
  //          rtbMessages.Text += "You hit the " + _opponent.Name + " for " + damageToMonster.ToString() + " points." + Environment.NewLine;

  //          // Check if the monster is dead
  //          if (_currentMonster.CurrentHitPoints <= 0)
  //          {
  //              // Monster is dead
  //              rtbMessages.Text += Environment.NewLine;
  //              rtbMessages.Text += "You defeated the " + _currentMonster.Name + Environment.NewLine;

  //              // Give player experience points for killing the monster
  //              _player.ExperiencePoints += _currentMonster.RewardExperiencePoints;
  //              rtbMessages.Text += "You receive " + _currentMonster.RewardExperiencePoints.ToString() + " experience points" + Environment.NewLine;

  //              // Get random loot items from the monster
  //              List<InventoryItem> lootedItems = new List<InventoryItem>();

  //              // Add items to the lootedItems list, comparing a random number to the drop percentage
  //              foreach (LootItem lootItem in _opponent.LootTable)
  //              {
  //                  if (RandomNumberGenerator.NumberBetween(1, 100) <= lootItem.DropPercentage)
  //                  {
  //                      lootedItems.Add(new InventoryItem(lootItem.Details, 1));
  //                  }
  //              }

  //              // If no items were randomly selected, then add the default loot item(s).
  //              if (lootedItems.Count == 0)
  //              {
  //                  foreach (LootItem lootItem in _currentMonster.LootTable)
  //                  {
  //                      if (lootItem.IsDefaultItem)
  //                      {
  //                          lootedItems.Add(new InventoryItem(lootItem.Details, 1));
  //                      }
  //                  }
  //              }

  //              // Add the looted items to the player's inventory
  //              foreach (InventoryItem inventoryItem in lootedItems)
  //              {
  //                  _player.AddItemToInventory(inventoryItem.Details);

  //                  if (inventoryItem.Quantity == 1)
  //                  {
  //                      rtbMessages.Text += "You loot " + inventoryItem.Quantity.ToString() + " " + inventoryItem.Details.Name + Environment.NewLine;
  //                  }
  //                  else
  //                  {
  //                      rtbMessages.Text += "You loot " + inventoryItem.Quantity.ToString() + " " + inventoryItem.Details.NamePlural + Environment.NewLine;
  //                  }
  //              }

  //              // Refresh player information and inventory controls
  //              lblHitPoints.Text = _player.CurrentHitPoints.ToString();
  //              lblGold.Text = _player.Gold.ToString();
  //              lblExperience.Text = _player.ExperiencePoints.ToString();
  //              lblLevel.Text = _player.Level.ToString();

  //              UpdateInventoryListInUI();
  //              UpdateWeaponListInUI();
  //              UpdatePotionListInUI();

  //              // Add a blank line to the messages box, just for appearance.
  //              rtbMessages.Text += Environment.NewLine;

  //              // Move player to current location (to heal player and create a new monster to fight)
  //              MoveTo(_player.CurrentLocation);
  //          }
  //          else
  //          {
  //              // Monster is still alive

  //              // Determine the amount of damage the monster does to the player
  //              int damageToPlayer = RandomNumberGenerator.NumberBetween(0, _currentMonster.MaximumDamage);

  //              // Display message
  //              rtbMessages.Text += "The " + _currentMonster.Name + " did " + damageToPlayer.ToString() + " points of damage." + Environment.NewLine;

  //              // Subtract damage from player
  //              _player.CurrentHitPoints -= damageToPlayer;

  //              // Refresh player data in UI
  //              lblHitPoints.Text = _player.CurrentHitPoints.ToString();

  //              if (_player.CurrentHitPoints <= 0)
  //              {
  //                  // Display message
  //                  rtbMessages.Text += "The " + _currentMonster.Name + " killed you." + Environment.NewLine;

  //                  // Move player to "Home"
  //                  MoveTo(World.LocationByID(World.LOCATION_ID_HOME));
  //              }
  //          }
  //      }

  //      private void btnUsePotion_Click(object sender, EventArgs e)
  //      {
  //          // Get the currently selected potion from the combo-box
  //          HealingPotion potion = (HealingPotion)cboPotions.SelectedItem;

  //          // Add healing amount to the player's current hit points
  //          _player.CurrentHitPoints = (_player.CurrentHitPoints + potion.AmountToHeal);

  //          // CurrentHitPoints cannot exceed player's MaximumHitPoints
  //          if (_player.CurrentHitPoints > _player.MaximumHitPoints)
  //          {
  //              _player.CurrentHitPoints = _player.MaximumHitPoints;
  //          }

  //          // Remove the potion from the player's inventory
  //          foreach (InventoryItem ii in _player.Inventory)
  //          {
  //              if (ii.Details.ID == potion.ID)
  //              {
  //                  ii.Quantity--;
  //                  break;
  //              }
  //          }

  //          // Display message
  //          rtbMessages.Text += "You drink a " + potion.Name + Environment.NewLine;

  //          // Monster gets their turn to attack

  //          // Determine the amount of damage the monster does to the player
  //          int damageToPlayer = RandomNumberGenerator.NumberBetween(0, _currentMonster.MaximumDamage);

  //          // Display message
  //          rtbMessages.Text += "The " + _currentMonster.Name + " did " + damageToPlayer.ToString() + " points of damage." + Environment.NewLine;

  //          // Subtract damage from player
  //          _player.CurrentHitPoints -= damageToPlayer;

  //          if (_player.CurrentHitPoints <= 0)
  //          {
  //              // Display message
  //              rtbMessages.Text += "The " + _currentMonster.Name + " killed you." + Environment.NewLine;

  //              // Move player to "Home"
  //              MoveTo(World.LocationByID(World.LOCATION_ID_HOME));
  //          }

  //          // Refresh player data in UI
  //          lblHitPoints.Text = _player.CurrentHitPoints.ToString();
  //          UpdateInventoryListInUI();
  //          UpdatePotionListInUI();
  //      }

  //      private void cboWeapons_SelectedIndexChanged(object sender, EventArgs e)
  //      {

  //      }


            

  //      }
    
    }
}
