using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace PlayerUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
            
        }

      
        private void customizeDesign()
        {
            panelMediaSubmenu.Visible = false;
            panelToolSubMenu.Visible = false;
            panelPlaylistSubMenu.Visible = false;
            textExit.Visible = false;
            btnExitNo.Visible = false;
            btnExitYes.Visible = false;
           
        }
        private void hideSubMenu()
        {
            if (panelMediaSubmenu.Visible == true)
                panelMediaSubmenu.Visible = false;
            if (panelPlaylistSubMenu.Visible == true)
                panelPlaylistSubMenu.Visible = false;
            if (panelToolSubMenu.Visible == true)
                panelToolSubMenu.Visible = false;
            
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;



            }
            else
                subMenu.Visible = false;

        }


       

       

        /* --------------------------------------Media-------------------------------------------------------*/

        private void button1_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubmenu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        /* ---------------------------------Playlist------------------------------------------------------------*/


        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPlaylistSubMenu);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.y8.com/");
            hideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.y8.com/games/slope");
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.y8.com/games/color_tunnel");
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.y8.com/games/drift_boss");
            hideSubMenu();
        }

  

        /* --------------------------------------Tools-------------------------------------------------------*/

        private void btnTools_Click(object sender, EventArgs e)
        {
            showSubMenu(panelToolSubMenu);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }



        /* --------------------------------------EXIT-------------------------------------------------------*/


        private void btnHelp_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            textExit.Visible = true;
            if (textExit.Visible = true)
            {
                btnExitYes.Visible = true;
                btnExitNo.Visible = true;
            }
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnExitNo_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            textExit.Visible = false;
            btnExitYes.Visible = false;
            btnExitNo.Visible = false;
        }

        private void btnExitYes_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}