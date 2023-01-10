using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cavalier
{
  public partial class Form1 : Form
  {
    Color couleurpaire = Color.White;
    Color couleurimpaire = Color.Black;
    Color couleurmoov = Color.Red;
    Form2 form2;
    List<Boolean> etats = new List<Boolean>();
    public int count = 0;
    MyButton[,] grille;
    int taille = 12;
    int border = 2;
    int xform2, yform2;
    public Form1()
    {
      InitializeComponent();
    }
    //-------------------------------------------------------------------
    private void Form1_Load(object sender, EventArgs e)
    {
      this.label1.Text = "";
      this.label2.Text = "";
      this.label3.Text = "";
      this.grille = new MyButton[taille, taille];
      this.button1.Visible = true;
      this.button1.Text = "Replay";
      for (int j = 0; j < taille; j++)
      {
        for (int k = 0; k < taille; k++)
        {
          MyButton b = new MyButton();
          if (j % 2 == 0 && k % 2 == 1 || k % 2 == 0 && j % 2 == 1)
          {
            b.BackColor = couleurpaire;
          }
          else
          {
            b.BackColor = couleurimpaire;
          }
          b.Location = new System.Drawing.Point(0 + (j * 50), 0 + (k * 50));
          b.Size = new System.Drawing.Size(50, 50);
          b.Text = "";
          b.X = j;
          b.Y = k;
          this.Controls.Add(b);
          b.Click += new System.EventHandler(this.b_Click);
          if (j < 2 || j > 9 || k < 2 || k > 9)
          {
            b.Enabled = false;
            b.Visible = false;
          }
          grille[j, k] = b;
        }
      }
    }
    //-------------------------------------------------------------------
    private void b_Click(object sender, EventArgs e)
    {
      if (count != 0)
      {
        this.label3.Text = "";
      }
      this.choixDeCouleursToolStripMenuItem.Enabled = false;
      count++;
      etats.Clear();
      MyButton b;
      if (sender is MyButton)
      {
        b = sender as MyButton;
        if (count == 1)
        {
          xform2 = b.X;
          yform2 = b.Y;
        }
        else if (count == 0)
        {
          Random random = new Random();
          xform2 = random.Next(1, 8);
          yform2 = random.Next(1, 8);
        }
        for (int j = 0; j < taille; j++)
        {
          for (int k = 0; k < taille; k++)
          {
            if (j % 2 == 0 && k % 2 == 1 || k % 2 == 0 && j % 2 == 1)
            {
              grille[j, k].BackColor = couleurpaire;
            }
            else
            {
              grille[j, k].BackColor = couleurimpaire;
            }
            grille[j, k].Enabled = false;
          }
        }
        grille[b.X, b.Y].Enabled = false;
        grille[b.X, b.Y].Visible = false;
        grille[b.X, b.Y].IsUsed = true;
        if (count == 64)
        {
          this.label1.Text = "Congrats!!! You won";
        }
        this.label2.Text = "Your score is: " + count.ToString();
        if (!grille[b.X - 1, b.Y - 2].IsUsed)
        {
          grille[b.X - 1, b.Y - 2].BackColor = couleurmoov;
          grille[b.X - 1, b.Y - 2].Enabled = true;
        }

        if (!grille[b.X - 1, b.Y + 2].IsUsed)
        {
          grille[b.X - 1, b.Y + 2].BackColor = couleurmoov;
          grille[b.X - 1, b.Y + 2].Enabled = true;
        }

        if (!grille[b.X - 2, b.Y - 1].IsUsed)
        {
          grille[b.X - 2, b.Y - 1].BackColor = couleurmoov;
          grille[b.X - 2, b.Y - 1].Enabled = true;
        }

        if (!grille[b.X - 2, b.Y + 1].IsUsed)
        {
          grille[b.X - 2, b.Y + 1].BackColor = couleurmoov;
          grille[b.X - 2, b.Y + 1].Enabled = true;
        }

        if (!grille[b.X + 1, b.Y - 2].IsUsed)
        {
          grille[b.X + 1, b.Y - 2].BackColor = couleurmoov;
          grille[b.X + 1, b.Y - 2].Enabled = true;
        }

        if (!grille[b.X + 1, b.Y + 2].IsUsed)
        {
          grille[b.X + 1, b.Y + 2].BackColor = couleurmoov;
          grille[b.X + 1, b.Y + 2].Enabled = true;
        }

        if (!grille[b.X + 2, b.Y - 1].IsUsed)
        {
          grille[b.X + 2, b.Y - 1].BackColor = couleurmoov;
          grille[b.X + 2, b.Y - 1].Enabled = true;
        }

        if (!grille[b.X + 2, b.Y + 1].IsUsed)
        {
          grille[b.X + 2, b.Y + 1].BackColor = couleurmoov;
          grille[b.X + 2, b.Y + 1].Enabled = true;
        }
      }
      analyse();
    }

    //-------------------------------------------------------------------
    private void button1_Click(object sender, EventArgs e)
    {
      this.label1.Text = "";
      this.label2.Text = "";
      this.label3.Text = "";
      this.choixDeCouleursToolStripMenuItem.Enabled = true;
      count = 0;
      for (int j = 0; j < taille; j++)
      {
        for (int k = 0; k < taille; k++)
        {
          MyButton b = new MyButton();
          if (j % 2 == 0 && k % 2 == 1 || k % 2 == 0 && j % 2 == 1)
          {
            grille[j, k].BackColor = couleurpaire;
            grille[j, k].Visible = true;
            grille[j, k].Enabled = true;
            grille[j, k].IsUsed = false;
          }
          else
          {
            grille[j, k].BackColor = couleurimpaire;
            grille[j, k].Visible = true;
            grille[j, k].Enabled = true;
            grille[j, k].IsUsed = false;
          }
          if (j < 2 || j > 9 || k < 2 || k > 9)
          {
            grille[j, k].Enabled = false;
            grille[j, k].Visible = false;
            grille[j, k].IsUsed = false;
          }
        }
      }
    }
    //-------------------------------------------------------------------
    private void Form1_Paint(object sender, PaintEventArgs e)
    {
      Graphics g = this.CreateGraphics();
      Image img = Image.FromFile("images\\Cavalier.JPG");
      g.DrawImage(img, 100, 100, 400, 400);
    }
    //-------------------------------------------------------------------
    private void analyse()
    {
      for (int j = border; j < taille - border; j++)
      {
        for (int k = border; k < taille - border; k++)
        {
          etats.Add(grille[j, k].Enabled);
        }
      }
      if (etats.Contains(true))
      {
        this.label1.Text = "Keep Going";
      }
      else
      {
        this.label1.Text = " You lost";
        this.button1.Visible = true;
      }
      if (count == 64)
      {
        this.label1.Text = " Congrats!!! You won";
      }
    }
    //------------------------------------------------------------------
    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      DialogResult reponse = MessageBox.Show(
          "Sure you want to quit?",
          "Quitting",
          MessageBoxButtons.YesNo,
          MessageBoxIcon.Question,
          MessageBoxDefaultButton.Button2,
          MessageBoxOptions.RightAlign);
      if (reponse == DialogResult.No)
      {
        e.Cancel = true;
      }
    }
    //------------------------------------------------------------------
    private void simulationToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }
    //------------------------------------------------------------------
    private void réglesDuJeuToolStripMenuItem_Click(object sender, EventArgs e)
    {
      DialogResult reponse = MessageBox.Show(
          "Le but est de faire parcourir à un cavalier l'ensemble d'un échiquier sans passer deux fois sur la même case\n" +
          "En cas de perte, il sera possible de rejouer\n" +
          "Si vous voulez voir une simulation, une rubrique est dédiée dans le menu ",
          "",
          MessageBoxButtons.OK,
          MessageBoxIcon.Information,
          MessageBoxDefaultButton.Button1);
    }
    //------------------------------------------------------------------
    private void casesPairesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ColorDialog MyDialog = new ColorDialog();
      MyDialog.AllowFullOpen = false;
      MyDialog.ShowHelp = true;
      if (MyDialog.ShowDialog() == DialogResult.OK)
      {
        couleurpaire = MyDialog.Color;
        for (int j = 0; j < taille; j++)
        {
          for (int k = 0; k < taille; k++)
          {
            if (j % 2 == 0 && k % 2 == 1 || k % 2 == 0 && j % 2 == 1)
            {
              grille[j, k].BackColor = couleurpaire;
            }
          }
        }
      }


    }
    //------------------------------------------------------------------
    private void casesImpairesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ColorDialog MyDialog = new ColorDialog();
      MyDialog.AllowFullOpen = false;
      MyDialog.ShowHelp = true;
      if (MyDialog.ShowDialog() == DialogResult.OK)
      {
        couleurimpaire = MyDialog.Color;
        for (int j = 0; j < taille; j++)
        {
          for (int k = 0; k < taille; k++)
          {
            if (!(j % 2 == 0 && k % 2 == 1 || k % 2 == 0 && j % 2 == 1))
            {
              grille[j, k].BackColor = couleurimpaire;
            }
          }
        }
      }
    }
    //------------------------------------------------------------------
    private void casesDeMouvementToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ColorDialog MyDialog = new ColorDialog();
      MyDialog.AllowFullOpen = false;
      MyDialog.ShowHelp = true;
      if (MyDialog.ShowDialog() == DialogResult.OK)
      {
        couleurmoov = MyDialog.Color;
      }
    }
    //------------------------------------------------------------------
    private void départAléatoireToolStripMenuItem_Click(object sender, EventArgs e)
    {
      form2 = new Form2(this);
      form2.Show();
    }
    //------------------------------------------------------------------
    private void départDeLaPartieDuJeuToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (count != 0)
      {
        form2 = form2 = new Form2(this, xform2, yform2);
        form2.Show();
      }
      if (count == 0)
      {
        this.label3.Text = "You have to click at least one case to" +
          " start the simulation in this mode";
      }
    }
  }
}
