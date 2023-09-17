using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Activity_4_Breakfast_Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a,b;
            a = comboBox1.SelectedItem.ToString();
            if (a == btnHouse.Text)
            {
                comboBox1.Items.Add("a");
            }
        }

        private void btnHouse_CheckedChanged(object sender, EventArgs e)
        {
            if (btnHouse.Checked)
            {
                groupBox5.Text = "House Made Waffel ";
                comboBox1.Text="Please Select a House Waffel Item !";
                comboBox1.Items.Add("Belgian Waffle Combo $13.99"); 
                comboBox1.Items.Add("Chicken Tenders and Waffles $13.99");
                comboBox1.Items.Add("Belgian Waffle Classic $11.99"); 
                comboBox1.Items.Add("Malaysian Waffle Combo $12.99");
                comboBox1.Items.Add("Chinese Waffle Combo $15.99");
               // comboBox1.Items.Add("");

            }
            
        }

        private void btnPancakes_CheckedChanged(object sender, EventArgs e)
        {
            if(btnPancakes.Checked)
              
            {
                groupBox5.Text = "World-Famous Pancakes ";
                comboBox1.Text = "Please Select a World Pancake Item!";
                comboBox1.Items.Add("Authentic Taiwanese Pancake $15.99");
                comboBox1.Items.Add("Chinese Classic Pancake $14.99");
                comboBox1.Items.Add("French Oat Pancake $11.99");
                comboBox1.Items.Add("Italian Strawberry Pancake $12.99");
                comboBox1.Items.Add("Greek Triple Yogurt Pancake $13.75");
                comboBox1.Items.Add("Mexican Tres Leches Pancake $13.99");
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            
            if (radioButton3.Checked) {

                groupBox5.Text = "House Authentic Omelet ";
                comboBox1.Text = "Please Select a House Authentic Omelet Item!";
                comboBox1.Items.Add("Cheese Omelet $6.99");
                comboBox1.Items.Add("Western Omelet $8.99");
                comboBox1.Items.Add("Vegetable Omelet $7.99");
                comboBox1.Items.Add("Meat Lover’s Omelet $10.99");
                comboBox1.Items.Add("Spinach Omelet $9.99");
                comboBox1.Items.Add("Greek Omelet $9.99");
             

            }
        }

        private void btnToday_CheckedChanged(object sender, EventArgs e)
        {
            if (btnToday.Checked) {
                groupBox5.Text = "Today's Special";
                comboBox1.Text = "Please Select a Special Today Item!";
                comboBox1.Items.Add("Kid Special I (1 Egg + Pancake with 2 pieces of Bacon) $5.99");
                comboBox1.Items.Add("Kid Special II (1 Egg + Pancake with 1 Pattie Sausage) $5.99");
                comboBox1.Items.Add("Kid Special III (1 Egg + Pancake with 2 Links sausage) $5.99");
                
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton6.Checked)
            {
                lbDiscount.Text = "Discount (25%)";
            }
        }

        private void btnMilitary_CheckedChanged(object sender, EventArgs e)
        {
            if (btnMilitary.Checked)
            {
                lbDiscount.Text = "Discount (15.35%)";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            const decimal specialcost = 5.59m;
            const decimal speciallcost = 5.59m;
            const decimal specialllcost = 5.59m;
            const decimal cheeseOmlet = 6.99m;
            const decimal westernOmelet = 8.99m;
            const decimal vegetableOmelet = 7.99m;
            const decimal spinachOmelet = 9.99m;
            const decimal onionOmelet = 9.99m;
            const decimal Authentic = 15.99m;
            const decimal Chinese = 14.99m;
            const decimal French = 11.99m;
            const decimal Italian = 12.99m;
            const decimal Greek = 13.75m;
            const decimal Mexican = 13.99m;
            const decimal belgianWaffle = 13.99m;
            const decimal chickenTenders = 13.99m;
            const decimal belgianWaffleClassic = 11.99m;
            const decimal malaysianWaffle = 12.99m;
            const decimal chineseWaffleCombo = 15.99m;
            const decimal employee = 0.25m;
            const decimal Military = 0.1535m;


            decimal sumbelgianWaffle = 0;
            decimal sumchickenTenders = 0;
            decimal sumbelgianWaffleClassic = 0;
            decimal summalaysianWaffle = 0;
            decimal sumchineswWaffleCombo = 0;
            decimal sumspecial = 0;
            decimal sumspeciall = 0;
            decimal sumspecialll = 0;
            decimal sumcheeseOmlet = 0;
            decimal sumwesterOmelet = 0;
            decimal sumvegetableOmelet = 0;
            decimal sumspinachOmelet = 0;
            decimal sumonionOmelet = 0;
            decimal summeatomlet = 0;
            decimal sumAuthentic = 0;
            decimal sumChinese = 0;
            decimal sumFrench = 0;
            decimal sumItalian = 0;
            decimal sumGreek = 0;
            decimal sumMexican = 0;
            decimal sumEmployee = 0;
            decimal sumMilitary = 0;
            decimal sumNone;
            decimal sumdiscount;
            decimal discount;
            decimal sumTax;
            decimal sumsubtotal;
            decimal sumtotall;
            decimal sumsumsbtotal;
            decimal sumsumcolddrink = 0;
            decimal sumhotdrinkone = 0;
            decimal summondrinktwo = 0;
            decimal summondrinkthree = 0;
            decimal sumspanich = 0;
            decimal sumgreek = 0;


            if (btnToday.Checked && comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Today's Special Selection Required. \r\n" + "Please select one of these Items ", " “Non-Selection Error Encounte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Restart();

            }
            if (radioButton3.Checked && comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("House Authentic Omelets Selection Required. \r\n" + "Please select one of these Items ", " “Non-Selection Error Encounte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Restart();

            }
            if (btnPancakes.Checked && comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("World-Famous Pancakes Selection Required. \r\n" + "Please select one of these Items ", " “Non-Selection Error Encounte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Restart();

            }
            if (btnHouse.Checked && comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("House-Made Waffles Selection Required. \r\n" + "Please select one of these Items ", " “Non-Selection Error Encounte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Restart();

            }
      
            if (btnToday.Checked && comboBox1.SelectedIndex == 0 )
            {
                sumspecial = + specialcost;
               
               
            }
           
            if (btnToday.Checked && comboBox1.SelectedIndex == 1 )
            {
                sumspeciall = +speciallcost;
            }if (btnToday.Checked && comboBox1.SelectedIndex == 2)
            {
                sumspecialll = +specialllcost;
            }
            if (radioButton3.Checked && comboBox1.SelectedIndex == 0)
            {
                sumcheeseOmlet = +cheeseOmlet;
            }
            if (radioButton3.Checked && comboBox1.SelectedIndex == 1)
            {
                sumwesterOmelet = +westernOmelet;
            }
            if (radioButton3.Checked && comboBox1.SelectedIndex == 2)
            {
                sumvegetableOmelet = +vegetableOmelet;
            }
            if (radioButton3.Checked && comboBox1.SelectedIndex == 3)
            {
                summeatomlet = +10.99m;
            }
            if (radioButton3.Checked && comboBox1.SelectedIndex == 4)
            {
                sumonionOmelet = +onionOmelet;
            }
            if (radioButton3.Checked && comboBox1.SelectedIndex == 5)
            {
                sumspanich = +onionOmelet;
            }
            if (radioButton3.Checked && comboBox1.SelectedIndex == 6)
            {
                sumgreek= +onionOmelet;
            }


            if (btnPancakes.Checked && comboBox1.SelectedIndex == 0)
            {
                sumAuthentic = + 15.99m;
            }
            if (btnPancakes.Checked && comboBox1.SelectedIndex == 1)
            {
                sumChinese = +Chinese;
            }

            if (btnPancakes.Checked && comboBox1.SelectedIndex == 2)
            {
                sumFrench = +French;
            }
            if (btnPancakes.Checked && comboBox1.SelectedIndex == 3)
            {
                sumItalian = +Italian;
            }
            if (btnPancakes.Checked && comboBox1.SelectedIndex == 4)
            {
                sumGreek = +Greek;
            }
            if (btnPancakes.Checked && comboBox1.SelectedIndex == 5)
            {
                sumMexican = +Mexican;
            }

            if (btnHouse.Checked && comboBox1.SelectedIndex == 0)
            {
                sumbelgianWaffle = +belgianWaffle;
            }

            if (btnHouse.Checked && comboBox1.SelectedIndex == 1)
                {
                    sumchickenTenders = +chickenTenders;
                }
            if (btnHouse.Checked && comboBox1.SelectedIndex == 2)
                {
                    sumbelgianWaffleClassic = +belgianWaffleClassic;
                }

            if (btnHouse.Checked && comboBox1.SelectedIndex == 3)
                {
                    summalaysianWaffle = +malaysianWaffle;
                }
            if (btnHouse.Checked && comboBox1.SelectedIndex == 4)
                {
                    sumchineswWaffleCombo = +chineseWaffleCombo;

                }
            if(radioButton6.Checked)
            {
                sumEmployee = +employee;
            }
            if (btnMilitary.Checked)
            {
                sumMilitary = Military;
            }
            if (btnNone.Checked)
            {
                lbresultDiscount.ForeColor = Color.White;
                sumNone = +0;
            }
            if (checkMuffin.Checked || checkCake.Checked || checkHash.Checked || checkMatcha.Checked || checkLychee.Checked || checkGreen.Checked || checkMilk.Checked || checkEspresso.Checked || checkPuccino.Checked || checkLatte.Checked || checkCoca.Checked || checkFanta.Checked || checkAw.Checked || checkMello.Checked || checkPepper.Checked)
            {

                if (checkCoca.Checked || checkFanta.Checked || checkAw.Checked || checkMello.Checked || checkPepper.Checked)
                {
                    sumsumcolddrink = +1.99m;
                }
                if (checkEspresso.Checked || checkPuccino.Checked || checkLatte.Checked)
                {
                    sumhotdrinkone = +5.99m;
                }
                if (checkMatcha.Checked || checkLychee.Checked || checkGreen.Checked || checkMilk.Checked)
                {
                    summondrinktwo = +4.99m;
                }
                if (checkMuffin.Checked || checkCake.Checked || checkHash.Checked)
                {
                    summondrinkthree = +2.99m;
                }
            }
          
            else
            {
                if (MessageBox.Show("Are you sure you want process without any add_on Items \r\n", " “No Add On Items Selected", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)

                    Application.Restart();
                

            }





            discount = sumMilitary + sumEmployee;
            sumsubtotal = sumgreek + sumspanich + summeatomlet + summondrinkthree +summondrinktwo + sumspecial + sumspeciall + sumspecialll + sumcheeseOmlet + sumwesterOmelet + sumvegetableOmelet + sumspinachOmelet + sumonionOmelet + sumAuthentic + sumChinese + sumFrench + sumItalian + sumGreek + sumMexican + sumbelgianWaffle + sumchickenTenders + sumbelgianWaffleClassic + summalaysianWaffle+ sumhotdrinkone + sumchineswWaffleCombo + sumsumcolddrink;
            sumdiscount = discount * sumsubtotal;
            sumTax = (sumsubtotal - sumdiscount)* 0.0775m;
            sumsumsbtotal = sumsubtotal - sumdiscount;
            sumtotall = sumTax + sumsumsbtotal;

            lbTax.Text =sumTax.ToString("N2");
            lbresultDiscount.Text = sumdiscount.ToString("C2");
            lbSubtotal.Text = sumsumsbtotal.ToString("C2");
            lbTotal.Text = sumtotall.ToString("C2");

        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNone_CheckedChanged(object sender, EventArgs e)
        {
            lbresultDiscount.Text = "";
        }
    }
}
