﻿namespace GUI
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listView_Player = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_NPC = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_Mobs = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_Entities = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tPHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox_Playerlist = new System.Windows.Forms.CheckBox();
            this.checkBox_NPCList = new System.Windows.Forms.CheckBox();
            this.checkBox_MobList = new System.Windows.Forms.CheckBox();
            this.checkBox_EntityList = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_Player
            // 
            this.listView_Player.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView_Player.ContextMenuStrip = this.contextMenuStrip1;
            this.listView_Player.FullRowSelect = true;
            this.listView_Player.Location = new System.Drawing.Point(588, 13);
            this.listView_Player.MultiSelect = false;
            this.listView_Player.Name = "listView_Player";
            this.listView_Player.Size = new System.Drawing.Size(333, 304);
            this.listView_Player.TabIndex = 1;
            this.listView_Player.UseCompatibleStateImageBehavior = false;
            this.listView_Player.View = System.Windows.Forms.View.Details;
            this.listView_Player.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_Player_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Username";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Location";
            this.columnHeader2.Width = 200;
            // 
            // listView_NPC
            // 
            this.listView_NPC.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.listView_NPC.ContextMenuStrip = this.contextMenuStrip1;
            this.listView_NPC.FullRowSelect = true;
            this.listView_NPC.Location = new System.Drawing.Point(927, 13);
            this.listView_NPC.MultiSelect = false;
            this.listView_NPC.Name = "listView_NPC";
            this.listView_NPC.Size = new System.Drawing.Size(333, 304);
            this.listView_NPC.TabIndex = 2;
            this.listView_NPC.UseCompatibleStateImageBehavior = false;
            this.listView_NPC.View = System.Windows.Forms.View.Details;
            this.listView_NPC.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_NPC_MouseDoubleClick);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Username";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Level";
            this.columnHeader4.Width = 150;
            // 
            // listView_Mobs
            // 
            this.listView_Mobs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.listView_Mobs.ContextMenuStrip = this.contextMenuStrip1;
            this.listView_Mobs.FullRowSelect = true;
            this.listView_Mobs.Location = new System.Drawing.Point(588, 366);
            this.listView_Mobs.MultiSelect = false;
            this.listView_Mobs.Name = "listView_Mobs";
            this.listView_Mobs.Size = new System.Drawing.Size(333, 304);
            this.listView_Mobs.TabIndex = 3;
            this.listView_Mobs.UseCompatibleStateImageBehavior = false;
            this.listView_Mobs.View = System.Windows.Forms.View.Details;
            this.listView_Mobs.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_Mobs_MouseDoubleClick);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Username";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Level";
            this.columnHeader6.Width = 150;
            // 
            // listView_Entities
            // 
            this.listView_Entities.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8});
            this.listView_Entities.ContextMenuStrip = this.contextMenuStrip1;
            this.listView_Entities.FullRowSelect = true;
            this.listView_Entities.Location = new System.Drawing.Point(927, 366);
            this.listView_Entities.MultiSelect = false;
            this.listView_Entities.Name = "listView_Entities";
            this.listView_Entities.Size = new System.Drawing.Size(333, 304);
            this.listView_Entities.TabIndex = 4;
            this.listView_Entities.UseCompatibleStateImageBehavior = false;
            this.listView_Entities.View = System.Windows.Forms.View.Details;
            this.listView_Entities.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_Entities_MouseDoubleClick);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Username";
            this.columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Level";
            this.columnHeader8.Width = 150;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tPHereToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(115, 26);
            // 
            // tPHereToolStripMenuItem
            // 
            this.tPHereToolStripMenuItem.Name = "tPHereToolStripMenuItem";
            this.tPHereToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.tPHereToolStripMenuItem.Text = "TP here";
            this.tPHereToolStripMenuItem.Click += new System.EventHandler(this.tPHereToolStripMenuItem_Click);
            // 
            // checkBox_Playerlist
            // 
            this.checkBox_Playerlist.AutoSize = true;
            this.checkBox_Playerlist.Location = new System.Drawing.Point(588, 318);
            this.checkBox_Playerlist.Name = "checkBox_Playerlist";
            this.checkBox_Playerlist.Size = new System.Drawing.Size(51, 18);
            this.checkBox_Playerlist.TabIndex = 6;
            this.checkBox_Playerlist.Text = "Scan";
            this.checkBox_Playerlist.UseVisualStyleBackColor = true;
            // 
            // checkBox_NPCList
            // 
            this.checkBox_NPCList.AutoSize = true;
            this.checkBox_NPCList.Location = new System.Drawing.Point(927, 318);
            this.checkBox_NPCList.Name = "checkBox_NPCList";
            this.checkBox_NPCList.Size = new System.Drawing.Size(51, 18);
            this.checkBox_NPCList.TabIndex = 7;
            this.checkBox_NPCList.Text = "Scan";
            this.checkBox_NPCList.UseVisualStyleBackColor = true;
            // 
            // checkBox_MobList
            // 
            this.checkBox_MobList.AutoSize = true;
            this.checkBox_MobList.Location = new System.Drawing.Point(588, 671);
            this.checkBox_MobList.Name = "checkBox_MobList";
            this.checkBox_MobList.Size = new System.Drawing.Size(51, 18);
            this.checkBox_MobList.TabIndex = 8;
            this.checkBox_MobList.Text = "Scan";
            this.checkBox_MobList.UseVisualStyleBackColor = true;
            // 
            // checkBox_EntityList
            // 
            this.checkBox_EntityList.AutoSize = true;
            this.checkBox_EntityList.Location = new System.Drawing.Point(927, 671);
            this.checkBox_EntityList.Name = "checkBox_EntityList";
            this.checkBox_EntityList.Size = new System.Drawing.Size(51, 18);
            this.checkBox_EntityList.TabIndex = 9;
            this.checkBox_EntityList.Text = "Scan";
            this.checkBox_EntityList.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 722);
            this.Controls.Add(this.checkBox_EntityList);
            this.Controls.Add(this.checkBox_MobList);
            this.Controls.Add(this.checkBox_NPCList);
            this.Controls.Add(this.checkBox_Playerlist);
            this.Controls.Add(this.listView_Entities);
            this.Controls.Add(this.listView_Mobs);
            this.Controls.Add(this.listView_NPC);
            this.Controls.Add(this.listView_Player);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "FFXIV";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tPHereToolStripMenuItem;
        private System.Windows.Forms.ListView listView_Player;
        private System.Windows.Forms.ListView listView_NPC;
        private System.Windows.Forms.ListView listView_Mobs;
        private System.Windows.Forms.ListView listView_Entities;
        private System.Windows.Forms.CheckBox checkBox_Playerlist;
        private System.Windows.Forms.CheckBox checkBox_NPCList;
        private System.Windows.Forms.CheckBox checkBox_MobList;
        private System.Windows.Forms.CheckBox checkBox_EntityList;
    }
}

