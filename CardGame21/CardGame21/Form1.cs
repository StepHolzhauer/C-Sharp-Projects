using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGame21
{
    public partial class Form1 : Form
    {
        string[] cards = new string[] {"Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Prince", "Queen", "King"};
        int counter = 0;
        public int value = 0;
        int oldvalue = 0;
        public int acecheck = 0;

        public static class GetValues
        {
            public static int aceValue { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private int CardValues(string card)
        {
            if (card == "Ace")
                return 1;
            if (card == "Two")
                return 2;
            if (card == "Three")
                return 3;
            if (card == "Four")
                return 4;
            if (card == "Five")
                return 5;
            if (card == "Six")
                return 6;
            if (card == "Seven")
                return 7;
            if (card == "Eight")
                return 8;
            if (card == "Nine")
                return 9;
            if (card == "Ten")
                return 10;
            if (card == "Prince")
                return 11;
            if (card == "Queen")
                return 11;
            if (card == "King")
                return 11;

            return 0;
        }

        private int Randomizer(int min, int max)
        {
            Random _generator = new Random();
            return _generator.Next(min, max + 1);
        }


        public void UpdateInventoryListInUI()
        {
            string randomCard = cards[Randomizer(0, 12)];

            dgvCards.RowHeadersVisible = false;
            dgvCards.ColumnCount = 2;
            dgvCards.Columns[0].Name = "Turn";
            dgvCards.Columns[0].Width = 40;
            dgvCards.Columns[1].Name = "Card";
            dgvCards.Rows.Add(new[] { counter.ToString(), randomCard });
            if (randomCard == "Ace")
            {
                PopupAce popup = new PopupAce();
                popup.ShowDialog();
                popup.Dispose();
                value += GetValues.aceValue;
            }
            else
            {
                value += CardValues(randomCard);
            }
            
            lblValue.Text=value.ToString();

            if (value>21)
            {
                System.Windows.Forms.MessageBox.Show("You went over 21 and lost!");
                dgvCards.Rows.Clear();

                oldvalue = value;
                value = 0;
                counter = 0;
                lblOldValue.Text = oldvalue.ToString();
                lblValue.Text = value.ToString();
            }

        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            counter++;
            UpdateInventoryListInUI();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            dgvCards.Rows.Clear();

            oldvalue = value;
            value = 0;
            counter = 0;
            lblOldValue.Text = oldvalue.ToString();
            lblValue.Text = value.ToString();
        }

    }
}
