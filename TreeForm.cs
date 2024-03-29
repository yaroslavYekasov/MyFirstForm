﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstForm
{
    public partial class TreeForm : Form
    {
        TreeView tree;
        Button btn;
        Label lbl;
        TextBox txt;
        RadioButton r1, r2;
        CheckBox c1, c2;
        public TreeForm()
        {
            this.Height = 600;
            this.Width = 800;
            this.Text = "Vorm põhielementidega";
            tree = new TreeView();
            tree.Dock = DockStyle.Left;
            tree.BorderStyle = BorderStyle.Fixed3D;
            tree.AfterSelect += Tree_AfterSelect;
            TreeNode treeNode = new TreeNode("Elemendid");
            treeNode.Nodes.Add(new TreeNode("Nupp-Button"));
            btn = new Button();
            btn.Height = 40;
            btn.Width = 100;
            btn.Text = "Valjuta mind!";
            btn.Location = new Point(150, 50);
            btn.Click += Btn_Click;
            btn.MouseHover += button2_MouseHover;
            tree.MouseDoubleClick += button_MouseDOubleClick;

            treeNode.Nodes.Add(new TreeNode("Tekstkast_Textbox"));
            txt_box=new TextBox();
            txt_box.BoederStyle = BorderStyle.Fixed3D;
            txt_box.Height = 50;
            txt_box.Width = 100;
            txt_box.Text = "...";


            tree.Nodes.Add(new TreeNode("Radionup_Radiobutton"));
            lbl = new Label();
            lbl.Text = "Pealkiri";
            lbl.Location = new Point(tree.Width, 0);
            lbl.Size = new Size(this.Width, btn.Location.Y);
            lbl.BackColor = Color.LightGray;
            lbl.BorderStyle = BorderStyle.Fixed3D;
            lbl.Font = new Font("Tahoma", 24);
            tree.Nodes.Add(treeNode);
            this.Controls.Add(tree);
            txt = new TextBox();
            txt.BorderStyle = BorderStyle.Fixed3D;
            txt.Height = 50;
            txt.Width = 100;
            txt.Text = "...";
            txt.Location = new Point(tree.Width, btn.Top + btn.Height + 5);
            this.Controls.Add(txt);
            txt.Visible = true;
            treeNode.Nodes.Add(new TreeNode("Radionupp"));

            r2.CheckedChanged += new EventHandler(RadioButtons_Changed);
            this.Controls.Add(r1);
            this.Controls.Add(r2);
            c1 = new CheckBox();
            c1.Text= "Näita nupp";
            c1.Location = new Point(tree.Width, r1.Location.Y + r1.Height);
            this.Controls.Add(c1);

            c1.CheckedChanged += new EventHandler(C1_CheckedChanged);
            c2 = new CheckBox();


            c2.Text = "Naita veel midagi";

            c2.Location = new Point(tree.Width, c1.Location.Y + c1.Height);
            this.Controls.Add(c2);


            c2.CheckedChanged += new EventHandler(C1_CheckedChanged);
            // Image

            pb = new PictureBox();
            pb.Location = new Point(tree.Width, c2.Location.Y + c2.Height);
            pb.Image = new Bitmap("../../../sipsik.png");
            pb.Size = new Size(100, 100);
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.BorderStyle = BorderStyle.Fixed3D;
            this.Controls.Add(pb);

            //r1 = new RadioButton();
            //r1.Text = "VAlik";
            //r1.Visible = true;
            //r1.Location = new Point(tree.Width, txt.Location.Y + txt.Height);
            //r2 = new RadioButton();
            //r2.Text = "valik2";
            //r2.Visible = true;
            //r2.Location = new Point(tree.Width, c1.Location.Y + c1.Height);
            //this.Controls.Add(c1);

            //tree.Nodes.Add(treeNode);
            //this.Controls.Add(tree);

        }

        private void C1_CheckedChanged(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void RadioButtons_Changed(object? sender, EventArgs e)
        {
            
        }

        private void button_MouseDOubleClick(object? sender, MouseEventArgs e)
        {
            if (btn.Visible)
            {
                btn.Visible = false;
            }
            else { btn.Visible = true; }

            if (lbl.Visible)
            {
                lbl.Visible = false;
            }
            else { lbl.Visible = true; }


            if (txt.Visible)
            {
                txt.Visible = false;
            }
            else { txt.Visible = true; }

            if (r1.Visible == true)
            {
                r1.Visible = false;
                r2.Visible = false;
            }
            else if (r2.Visible == false)
            {
                r1.Visible = true;
                r2.Visible = true;
            }
        
        }

        private void button2_MouseHover(object? sender, EventArgs e)
        {
            btn.Text = "your Mouse cursosr on button";
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            //throw new NotImplementedException();

            if (btn.BackColor == Color.Blue)
            {
                btn.BackColor = Color.Chocolate;
            }
            else { btn.BackColor = Color.Blue; }
        }

        private void Tree_AfterSelect(object? sender, TreeViewEventArgs e)
        {
            {
                //throw new NotImplementedException();
                if (e.Node.Text == "Nupp-Button")
                {
                    this.Controls.Add(btn);
                }
                else if (e.Node.Text == "Silt-Label")
                {
                    this.Controls.Add(lbl);
                }
            }
        }

        private void Txt_box_KeyDown(object? sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                DialogResult resul = MessagesBox.Show("Kas sa oled kindel?", "Küsimus", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes) 
                {
                    txt_box.Enabled = false;
                    this.Text = Txt_box_KeyDown().Text; 
                }
            }
        }
    }
}
