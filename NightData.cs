using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MafiaHelper
{
    public partial class NightData : Form
    {
        int PlayerWeHave = 10;

        public NightData()
        {
            InitializeComponent();
        }

        private void NightData_Load(object sender, EventArgs e)
        {
            labelPlayersWeHave.Text = Convert.ToString(PlayerWeHave);
        }

        private void NightData_FormClosing(object sender, FormClosingEventArgs e)
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

        //Buttons
        //===============
        #region Buttons
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.BackColor == Color.Red)
            {
                textBox1.BackColor = Color.White;
                button1.BackColor = Color.Green;

                if (PlayerWeHave < 10)
                {
                    PlayerWeHave = PlayerWeHave + 1;
                }
            }
            else if (textBox1.BackColor == Color.White)
            {
                textBox1.BackColor = Color.Red;
                button1.BackColor = Color.Red;
                PlayerWeHave = PlayerWeHave - 1;
            }
            labelPlayersWeHave.Text = Convert.ToString(PlayerWeHave);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.BackColor == Color.Red)
            {
                textBox2.BackColor = Color.White;
                button2.BackColor = Color.Green;

                if (PlayerWeHave < 10)
                {
                    PlayerWeHave = PlayerWeHave + 1;
                }
            }
            else if (textBox2.BackColor == Color.White)
            {
                textBox2.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                PlayerWeHave = PlayerWeHave - 1;
            }
            labelPlayersWeHave.Text = Convert.ToString(PlayerWeHave);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.BackColor == Color.Red)
            {
                textBox3.BackColor = Color.White;
                button3.BackColor = Color.Green;
                if (PlayerWeHave < 10)
                {
                    PlayerWeHave = PlayerWeHave + 1;
                }
            }
            else if (textBox3.BackColor == Color.White)
            {
                textBox3.BackColor = Color.Red;
                button3.BackColor = Color.Red;
                PlayerWeHave = PlayerWeHave - 1;
            }
            labelPlayersWeHave.Text = Convert.ToString(PlayerWeHave);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox4.BackColor == Color.Red)
            {
                textBox4.BackColor = Color.White;
                button4.BackColor = Color.Green;
                if (PlayerWeHave < 10)
                {
                    PlayerWeHave = PlayerWeHave + 1;
                }
            }
            else if (textBox4.BackColor == Color.White)
            {
                textBox4.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                PlayerWeHave = PlayerWeHave - 1;
            }
            labelPlayersWeHave.Text = Convert.ToString(PlayerWeHave);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox5.BackColor == Color.Red)
            {
                textBox5.BackColor = Color.White;
                button5.BackColor = Color.Green;
                if (PlayerWeHave < 10)
                {
                    PlayerWeHave = PlayerWeHave + 1;
                }
            }
            else if (textBox5.BackColor == Color.White)
            {
                textBox5.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                PlayerWeHave = PlayerWeHave - 1;
            }
            labelPlayersWeHave.Text = Convert.ToString(PlayerWeHave);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox6.BackColor == Color.Red)
            {
                textBox6.BackColor = Color.White;
                button6.BackColor = Color.Green;
                if (PlayerWeHave < 10)
                {
                    PlayerWeHave = PlayerWeHave + 1;
                }
            }
            else if (textBox6.BackColor == Color.White)
            {
                textBox6.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                PlayerWeHave = PlayerWeHave - 1;
            }
            labelPlayersWeHave.Text = Convert.ToString(PlayerWeHave);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox7.BackColor == Color.Red)
            {
                textBox7.BackColor = Color.White;
                button7.BackColor = Color.Green;
                if (PlayerWeHave < 10)
                {
                    PlayerWeHave = PlayerWeHave + 1;
                }
            }
            else if (textBox7.BackColor == Color.White)
            {
                textBox7.BackColor = Color.Red;
                button7.BackColor = Color.Red;
                PlayerWeHave = PlayerWeHave - 1;
            }
            labelPlayersWeHave.Text = Convert.ToString(PlayerWeHave);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox8.BackColor == Color.Red)
            {
                textBox8.BackColor = Color.White;
                button8.BackColor = Color.Green;
                if (PlayerWeHave < 10)
                {
                    PlayerWeHave = PlayerWeHave + 1;
                }
            }
            else if (textBox8.BackColor == Color.White)
            {
                textBox8.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                PlayerWeHave = PlayerWeHave - 1;
            }
            labelPlayersWeHave.Text = Convert.ToString(PlayerWeHave);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox9.BackColor == Color.Red)
            {
                textBox9.BackColor = Color.White;
                button9.BackColor = Color.Green;
                if (PlayerWeHave < 10)
                {
                    PlayerWeHave = PlayerWeHave + 1;
                }
            }
            else if (textBox9.BackColor == Color.White)
            {
                textBox9.BackColor = Color.Red;
                button9.BackColor = Color.Red;
                PlayerWeHave = PlayerWeHave - 1;
            }
            labelPlayersWeHave.Text = Convert.ToString(PlayerWeHave);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox10.BackColor == Color.Red)
            {
                textBox10.BackColor = Color.White;
                button10.BackColor = Color.Green;
                if (PlayerWeHave < 10)
                {
                    PlayerWeHave = PlayerWeHave + 1;
                }
            }
            else if (textBox10.BackColor == Color.White)
            {
                textBox10.BackColor = Color.Red;
                button10.BackColor = Color.Red;
                PlayerWeHave = PlayerWeHave - 1;
            }
            labelPlayersWeHave.Text = Convert.ToString(PlayerWeHave);
        }
        #endregion
        //===============
        public void ClearAll()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
    }
}
