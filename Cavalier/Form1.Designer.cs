namespace Cavalier
{
  partial class Form1
  {
    /// <summary>
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Code généré par le Concepteur Windows Form

    /// <summary>
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
      this.button1 = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.réglesDuJeuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.simulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.départAléatoireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.départDeLaPartieDuJeuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.choixDeCouleursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.casesPairesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.casesImpairesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.casesDeMouvementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.label3 = new System.Windows.Forms.Label();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(815, 447);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(142, 51);
      this.button1.TabIndex = 0;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(786, 140);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(139, 48);
      this.label1.TabIndex = 1;
      this.label1.Text = "label1";
      // 
      // label2
      // 
      this.label2.Location = new System.Drawing.Point(786, 178);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(168, 37);
      this.label2.TabIndex = 2;
      this.label2.Text = "label2";
      // 
      // menuStrip1
      // 
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.réglesDuJeuToolStripMenuItem,
            this.simulationToolStripMenuItem,
            this.choixDeCouleursToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1082, 28);
      this.menuStrip1.TabIndex = 3;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // réglesDuJeuToolStripMenuItem
      // 
      this.réglesDuJeuToolStripMenuItem.Name = "réglesDuJeuToolStripMenuItem";
      this.réglesDuJeuToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
      this.réglesDuJeuToolStripMenuItem.Text = "Régles du jeu";
      this.réglesDuJeuToolStripMenuItem.Click += new System.EventHandler(this.réglesDuJeuToolStripMenuItem_Click);
      // 
      // simulationToolStripMenuItem
      // 
      this.simulationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.départAléatoireToolStripMenuItem,
            this.départDeLaPartieDuJeuToolStripMenuItem});
      this.simulationToolStripMenuItem.Name = "simulationToolStripMenuItem";
      this.simulationToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
      this.simulationToolStripMenuItem.Text = "Simulation";
      this.simulationToolStripMenuItem.Click += new System.EventHandler(this.simulationToolStripMenuItem_Click);
      // 
      // départAléatoireToolStripMenuItem
      // 
      this.départAléatoireToolStripMenuItem.Name = "départAléatoireToolStripMenuItem";
      this.départAléatoireToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
      this.départAléatoireToolStripMenuItem.Text = "Départ aléatoire";
      this.départAléatoireToolStripMenuItem.Click += new System.EventHandler(this.départAléatoireToolStripMenuItem_Click);
      // 
      // départDeLaPartieDuJeuToolStripMenuItem
      // 
      this.départDeLaPartieDuJeuToolStripMenuItem.Name = "départDeLaPartieDuJeuToolStripMenuItem";
      this.départDeLaPartieDuJeuToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
      this.départDeLaPartieDuJeuToolStripMenuItem.Text = "Départ de la partie du jeu";
      this.départDeLaPartieDuJeuToolStripMenuItem.Click += new System.EventHandler(this.départDeLaPartieDuJeuToolStripMenuItem_Click);
      // 
      // choixDeCouleursToolStripMenuItem
      // 
      this.choixDeCouleursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.casesPairesToolStripMenuItem,
            this.casesImpairesToolStripMenuItem,
            this.casesDeMouvementToolStripMenuItem});
      this.choixDeCouleursToolStripMenuItem.Name = "choixDeCouleursToolStripMenuItem";
      this.choixDeCouleursToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
      this.choixDeCouleursToolStripMenuItem.Text = "Choix de couleurs";
      // 
      // casesPairesToolStripMenuItem
      // 
      this.casesPairesToolStripMenuItem.Name = "casesPairesToolStripMenuItem";
      this.casesPairesToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
      this.casesPairesToolStripMenuItem.Text = "Cases paires";
      this.casesPairesToolStripMenuItem.Click += new System.EventHandler(this.casesPairesToolStripMenuItem_Click);
      // 
      // casesImpairesToolStripMenuItem
      // 
      this.casesImpairesToolStripMenuItem.Name = "casesImpairesToolStripMenuItem";
      this.casesImpairesToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
      this.casesImpairesToolStripMenuItem.Text = "Cases impaires";
      this.casesImpairesToolStripMenuItem.Click += new System.EventHandler(this.casesImpairesToolStripMenuItem_Click);
      // 
      // casesDeMouvementToolStripMenuItem
      // 
      this.casesDeMouvementToolStripMenuItem.Name = "casesDeMouvementToolStripMenuItem";
      this.casesDeMouvementToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
      this.casesDeMouvementToolStripMenuItem.Text = "Cases de mouvement";
      this.casesDeMouvementToolStripMenuItem.Click += new System.EventHandler(this.casesDeMouvementToolStripMenuItem_Click);
      // 
      // label3
      // 
      this.label3.Location = new System.Drawing.Point(786, 215);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(182, 74);
      this.label3.TabIndex = 4;
      this.label3.Text = "label3";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1082, 775);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "Form1";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.Load += new System.EventHandler(this.Form1_Load);
      this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem simulationToolStripMenuItem;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ToolStripMenuItem réglesDuJeuToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem choixDeCouleursToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem casesPairesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem casesImpairesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem casesDeMouvementToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem départAléatoireToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem départDeLaPartieDuJeuToolStripMenuItem;
  }
}

