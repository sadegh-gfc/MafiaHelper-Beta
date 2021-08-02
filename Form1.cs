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

namespace MafiaHelper
{
    public partial class MafiaHelper : Form
    {
        SplashScreen sp = new SplashScreen();
        bool IsSecondTimeUse = false;
        public MafiaHelper()
        {
            InitializeComponent();
        }

        private void MafiaHelper_Load(object sender, EventArgs e)
        {
            sp.Show();
            timer1.Start();

            comboSenario.SelectedIndex = 0;

            //menuStrip1.ForeColor = Color.White;
        }
        private void MafiaHelper_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult di = new DialogResult();

            di = MessageBox.Show("If You Want To Exit press Yes", "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (di == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (IsSecondTimeUse)
            {
                DialogResult r = new DialogResult();
                r = MessageBox.Show("Are You Sure About Change Senario?" + '\n' + "If You Sure About Change Senario Recomended Change Game Name Because Of Some Bug ",
                    "Game Erorr", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (r == DialogResult.Yes)
                {
                    ComboSelect();
                }
            }
            else
            {
                ComboSelect();
            }
            IsSecondTimeUse = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SaveInformation.path = textBoxPath.Text;
            SaveInformation.GameName = textGameName.Text;
            if (SaveInformation.path != string.Empty && SaveInformation.GameName != string.Empty)
            {
                ComboSelect();

                //SaveInformation.CheckFile();
                SaveInformation si = new SaveInformation();


                //SaveInformation si = SaveInformation.ContactList[0];
                si.Shot = textBox1.Text;
                si.Save = textBox2.Text;
                si.Estelam = textBox7.Text;
                if (SaveInformation.IsGhadim)
                {
                    si.Mozakere = textBox3.Text;
                }
                else
                {
                    si.GeroganGirir = textBox3.Text;
                    si.Negahbani = textBox4.Text;
                    si.GunJangi = textBox5.Text;
                    si.GunMashghi = textBox6.Text;
                }
                SaveInformation.ContactList.Add(si);

                SaveInformation.OperationSave();
                Clear();

                MessageBox.Show("Your Informations Saved!", "Save",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please Click On Path Or If You Diden't Write Game Name PLease Write it! ", "Erorr!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button8_Click(object sender, EventArgs e)
        {
            //"D:\\EhsanSadegh\\MafiaHelperWindowsForm\\MafiaHelperFolder\\MafiaHelper\\Game.txt"
            if (textBoxPath.Visible == false)
            {
                textBoxPath.Visible = true;
            }
            else
            {
                textBoxPath.Visible = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sp.Close();
            this.Opacity = 100;
            timer1.Stop();
            MessageBox.Show("You Are Using Now Beta Version! ", "Beta",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            comboSenario.SelectedIndex = 0;
            IsSecondTimeUse = true;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phoenix is Mafia Game Server We Are Enjoy To See You in Server" + '\n'+ "If You Want To Joyn Us Pleas Click Discord"
                + '\n' + "Windows Application Made By Sadegh_gfc" + '\n' + "Discords Bot Made By Saeed_Underline & Bardia_sg" +
                '\n' + "Beta Version! 2021" + '\n' + "دوستان اگر استقبال از برنامه خوب بود اپدیت گرافیکی و محاسبه شب قرار داده می شود", "Phoenix",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void discordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtxLink.Visible == false)
            {
                label15.Visible = true;
                rtxLink.Visible = true;
            }
            else
            {
                label15.Visible = false;
                rtxLink.Visible = false;
            }
            
        }
        public void Clear()
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox1.Text = "";
            textBox7.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            NightData nd = new NightData();

            nd.Show();
        }

        private void btnChangeGame_Click(object sender, EventArgs e)
        {
            //SaveInformation.DoesItHaveExistFile = false;
            SaveInformation.ClearFolder();
        }

        private void rtxLink_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }

        private void btnGameName_Click(object sender, EventArgs e)
        {
            if (textGameName.Visible == false)
            {
                textGameName.Visible = true;
            }
            else
            {
                textGameName.Visible = false;
            }
        }
        private void ComboSelect()
        {
            if (comboSenario.SelectedIndex == 1)
            {
                //if (SaveInformation.DoesItHaveExistFile == false)
                //{
               
               
                    label4.Text = "Mozakere";
                    label8.Text = "M";
                    SaveInformation.IsGhadim = true;
                    label9.Visible = false;
                    label3.Visible = false;
                    textBox4.Visible = false;
                    //button4.Visible = false;
                    MafiaHelper.ActiveForm.Size = new System.Drawing.Size(632, 472);
                    label5.Visible = false;
                    textBox5.Visible = false;
                    textBox6.Visible = false;
                    label11.Visible = false;
                    label10.Visible = false;
               
               
            }
            else if (comboSenario.SelectedIndex == 0)
            {
            label4.Text = "Gerogangiri";
            label9.Visible = true;
            label3.Visible = true;
            textBox4.Visible = true;
                        //button4.Visible = true;
            MafiaHelper.ActiveForm.Size = new System.Drawing.Size(632, 687);
            label5.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            label11.Visible = true;
            label10.Visible = true;
            }
        } 
    }
}