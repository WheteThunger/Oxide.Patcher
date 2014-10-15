﻿namespace OxidePatcher.Views
{
    partial class HookViewControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.detailsgroup = new System.Windows.Forms.GroupBox();
            this.detailstable = new System.Windows.Forms.TableLayoutPanel();
            this.methodnamelabel = new System.Windows.Forms.Label();
            this.methodnametextbox = new System.Windows.Forms.TextBox();
            this.buttonholder = new System.Windows.Forms.FlowLayoutPanel();
            this.flagbutton = new System.Windows.Forms.Button();
            this.unflagbutton = new System.Windows.Forms.Button();
            this.applybutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.namelabel = new System.Windows.Forms.Label();
            this.nametextbox = new System.Windows.Forms.TextBox();
            this.hooknamelabel = new System.Windows.Forms.Label();
            this.hooktypelabel = new System.Windows.Forms.Label();
            this.hooknametextbox = new System.Windows.Forms.TextBox();
            this.hooktypedropdown = new System.Windows.Forms.ComboBox();
            this.tabview = new System.Windows.Forms.TabControl();
            this.hooksettingstab = new System.Windows.Forms.TabPage();
            this.beforetab = new System.Windows.Forms.TabPage();
            this.aftertab = new System.Windows.Forms.TabPage();
            this.assemblylabel = new System.Windows.Forms.Label();
            this.typenamelabel = new System.Windows.Forms.Label();
            this.assemblytextbox = new System.Windows.Forms.TextBox();
            this.typenametextbox = new System.Windows.Forms.TextBox();
            this.detailsgroup.SuspendLayout();
            this.detailstable.SuspendLayout();
            this.buttonholder.SuspendLayout();
            this.tabview.SuspendLayout();
            this.SuspendLayout();
            // 
            // detailsgroup
            // 
            this.detailsgroup.Controls.Add(this.detailstable);
            this.detailsgroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.detailsgroup.Location = new System.Drawing.Point(5, 5);
            this.detailsgroup.Name = "detailsgroup";
            this.detailsgroup.Size = new System.Drawing.Size(623, 204);
            this.detailsgroup.TabIndex = 2;
            this.detailsgroup.TabStop = false;
            this.detailsgroup.Text = "Hook Details";
            // 
            // detailstable
            // 
            this.detailstable.ColumnCount = 2;
            this.detailstable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.53846F));
            this.detailstable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.46154F));
            this.detailstable.Controls.Add(this.typenametextbox, 1, 1);
            this.detailstable.Controls.Add(this.assemblytextbox, 1, 0);
            this.detailstable.Controls.Add(this.typenamelabel, 0, 1);
            this.detailstable.Controls.Add(this.assemblylabel, 0, 0);
            this.detailstable.Controls.Add(this.methodnamelabel, 0, 2);
            this.detailstable.Controls.Add(this.methodnametextbox, 1, 2);
            this.detailstable.Controls.Add(this.buttonholder, 0, 6);
            this.detailstable.Controls.Add(this.namelabel, 0, 3);
            this.detailstable.Controls.Add(this.nametextbox, 1, 3);
            this.detailstable.Controls.Add(this.hooknamelabel, 0, 4);
            this.detailstable.Controls.Add(this.hooktypelabel, 0, 5);
            this.detailstable.Controls.Add(this.hooknametextbox, 1, 4);
            this.detailstable.Controls.Add(this.hooktypedropdown, 1, 5);
            this.detailstable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailstable.Location = new System.Drawing.Point(3, 16);
            this.detailstable.Name = "detailstable";
            this.detailstable.RowCount = 7;
            this.detailstable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.detailstable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.detailstable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.detailstable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.detailstable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.detailstable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.detailstable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.detailstable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.detailstable.Size = new System.Drawing.Size(617, 185);
            this.detailstable.TabIndex = 0;
            // 
            // methodnamelabel
            // 
            this.methodnamelabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.methodnamelabel.Location = new System.Drawing.Point(3, 50);
            this.methodnamelabel.Name = "methodnamelabel";
            this.methodnamelabel.Size = new System.Drawing.Size(126, 25);
            this.methodnamelabel.TabIndex = 0;
            this.methodnamelabel.Text = "Method Name:";
            this.methodnamelabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // methodnametextbox
            // 
            this.methodnametextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.methodnametextbox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.methodnametextbox.Location = new System.Drawing.Point(135, 53);
            this.methodnametextbox.Name = "methodnametextbox";
            this.methodnametextbox.ReadOnly = true;
            this.methodnametextbox.Size = new System.Drawing.Size(479, 23);
            this.methodnametextbox.TabIndex = 0;
            this.methodnametextbox.TabStop = false;
            // 
            // buttonholder
            // 
            this.detailstable.SetColumnSpan(this.buttonholder, 2);
            this.buttonholder.Controls.Add(this.flagbutton);
            this.buttonholder.Controls.Add(this.unflagbutton);
            this.buttonholder.Controls.Add(this.applybutton);
            this.buttonholder.Controls.Add(this.deletebutton);
            this.buttonholder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonholder.Location = new System.Drawing.Point(3, 153);
            this.buttonholder.Name = "buttonholder";
            this.buttonholder.Size = new System.Drawing.Size(611, 29);
            this.buttonholder.TabIndex = 5;
            // 
            // flagbutton
            // 
            this.flagbutton.Location = new System.Drawing.Point(3, 3);
            this.flagbutton.Name = "flagbutton";
            this.flagbutton.Size = new System.Drawing.Size(55, 23);
            this.flagbutton.TabIndex = 4;
            this.flagbutton.Text = "Flag";
            this.flagbutton.UseVisualStyleBackColor = true;
            this.flagbutton.Click += new System.EventHandler(this.flagbutton_Click);
            // 
            // unflagbutton
            // 
            this.unflagbutton.Location = new System.Drawing.Point(64, 3);
            this.unflagbutton.Name = "unflagbutton";
            this.unflagbutton.Size = new System.Drawing.Size(62, 23);
            this.unflagbutton.TabIndex = 6;
            this.unflagbutton.Text = "Unflag";
            this.unflagbutton.UseVisualStyleBackColor = true;
            this.unflagbutton.Click += new System.EventHandler(this.unflagbutton_Click);
            // 
            // applybutton
            // 
            this.applybutton.Location = new System.Drawing.Point(132, 3);
            this.applybutton.Name = "applybutton";
            this.applybutton.Size = new System.Drawing.Size(96, 23);
            this.applybutton.TabIndex = 7;
            this.applybutton.Text = "Apply Changes";
            this.applybutton.UseVisualStyleBackColor = true;
            this.applybutton.Click += new System.EventHandler(this.applybutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(234, 3);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(87, 23);
            this.deletebutton.TabIndex = 5;
            this.deletebutton.Text = "Remove";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // namelabel
            // 
            this.namelabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.namelabel.Location = new System.Drawing.Point(3, 75);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(126, 25);
            this.namelabel.TabIndex = 6;
            this.namelabel.Text = "Name:";
            this.namelabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nametextbox
            // 
            this.nametextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nametextbox.Location = new System.Drawing.Point(135, 78);
            this.nametextbox.MaxLength = 40;
            this.nametextbox.Name = "nametextbox";
            this.nametextbox.Size = new System.Drawing.Size(479, 20);
            this.nametextbox.TabIndex = 1;
            this.nametextbox.TabStop = false;
            this.nametextbox.TextChanged += new System.EventHandler(this.nametextbox_TextChanged);
            // 
            // hooknamelabel
            // 
            this.hooknamelabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hooknamelabel.Location = new System.Drawing.Point(3, 100);
            this.hooknamelabel.Name = "hooknamelabel";
            this.hooknamelabel.Size = new System.Drawing.Size(126, 25);
            this.hooknamelabel.TabIndex = 8;
            this.hooknamelabel.Text = "Hook Name:";
            this.hooknamelabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // hooktypelabel
            // 
            this.hooktypelabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hooktypelabel.Location = new System.Drawing.Point(3, 125);
            this.hooktypelabel.Name = "hooktypelabel";
            this.hooktypelabel.Size = new System.Drawing.Size(126, 25);
            this.hooktypelabel.TabIndex = 9;
            this.hooktypelabel.Text = "Hook Type:";
            this.hooktypelabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // hooknametextbox
            // 
            this.hooknametextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hooknametextbox.Location = new System.Drawing.Point(135, 103);
            this.hooknametextbox.MaxLength = 40;
            this.hooknametextbox.Name = "hooknametextbox";
            this.hooknametextbox.Size = new System.Drawing.Size(479, 20);
            this.hooknametextbox.TabIndex = 2;
            this.hooknametextbox.TabStop = false;
            this.hooknametextbox.TextChanged += new System.EventHandler(this.hooknametextbox_TextChanged);
            // 
            // hooktypedropdown
            // 
            this.hooktypedropdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hooktypedropdown.FormattingEnabled = true;
            this.hooktypedropdown.Location = new System.Drawing.Point(135, 128);
            this.hooktypedropdown.Name = "hooktypedropdown";
            this.hooktypedropdown.Size = new System.Drawing.Size(479, 21);
            this.hooktypedropdown.TabIndex = 3;
            this.hooktypedropdown.TabStop = false;
            this.hooktypedropdown.SelectedIndexChanged += new System.EventHandler(this.hooktypedropdown_SelectedIndexChanged);
            // 
            // tabview
            // 
            this.tabview.Controls.Add(this.hooksettingstab);
            this.tabview.Controls.Add(this.beforetab);
            this.tabview.Controls.Add(this.aftertab);
            this.tabview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabview.Location = new System.Drawing.Point(5, 209);
            this.tabview.Name = "tabview";
            this.tabview.SelectedIndex = 0;
            this.tabview.Size = new System.Drawing.Size(623, 265);
            this.tabview.TabIndex = 3;
            // 
            // hooksettingstab
            // 
            this.hooksettingstab.Location = new System.Drawing.Point(4, 22);
            this.hooksettingstab.Name = "hooksettingstab";
            this.hooksettingstab.Padding = new System.Windows.Forms.Padding(3);
            this.hooksettingstab.Size = new System.Drawing.Size(615, 239);
            this.hooksettingstab.TabIndex = 0;
            this.hooksettingstab.Text = "Hook Settings";
            this.hooksettingstab.UseVisualStyleBackColor = true;
            // 
            // beforetab
            // 
            this.beforetab.Location = new System.Drawing.Point(4, 22);
            this.beforetab.Name = "beforetab";
            this.beforetab.Padding = new System.Windows.Forms.Padding(3);
            this.beforetab.Size = new System.Drawing.Size(615, 278);
            this.beforetab.TabIndex = 1;
            this.beforetab.Text = "MSIL Before";
            this.beforetab.UseVisualStyleBackColor = true;
            // 
            // aftertab
            // 
            this.aftertab.Location = new System.Drawing.Point(4, 22);
            this.aftertab.Name = "aftertab";
            this.aftertab.Size = new System.Drawing.Size(615, 278);
            this.aftertab.TabIndex = 2;
            this.aftertab.Text = "MSIL After";
            this.aftertab.UseVisualStyleBackColor = true;
            // 
            // assemblylabel
            // 
            this.assemblylabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assemblylabel.Location = new System.Drawing.Point(3, 0);
            this.assemblylabel.Name = "assemblylabel";
            this.assemblylabel.Size = new System.Drawing.Size(126, 25);
            this.assemblylabel.TabIndex = 1;
            this.assemblylabel.Text = "Assembly:";
            this.assemblylabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // typenamelabel
            // 
            this.typenamelabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typenamelabel.Location = new System.Drawing.Point(3, 25);
            this.typenamelabel.Name = "typenamelabel";
            this.typenamelabel.Size = new System.Drawing.Size(126, 25);
            this.typenamelabel.TabIndex = 1;
            this.typenamelabel.Text = "Type Name:";
            this.typenamelabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // assemblytextbox
            // 
            this.assemblytextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assemblytextbox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assemblytextbox.Location = new System.Drawing.Point(135, 3);
            this.assemblytextbox.Name = "assemblytextbox";
            this.assemblytextbox.ReadOnly = true;
            this.assemblytextbox.Size = new System.Drawing.Size(479, 23);
            this.assemblytextbox.TabIndex = 1;
            this.assemblytextbox.TabStop = false;
            // 
            // typenametextbox
            // 
            this.typenametextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typenametextbox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typenametextbox.Location = new System.Drawing.Point(135, 28);
            this.typenametextbox.Name = "typenametextbox";
            this.typenametextbox.ReadOnly = true;
            this.typenametextbox.Size = new System.Drawing.Size(479, 23);
            this.typenametextbox.TabIndex = 1;
            this.typenametextbox.TabStop = false;
            // 
            // HookViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabview);
            this.Controls.Add(this.detailsgroup);
            this.Name = "HookViewControl";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(633, 479);
            this.detailsgroup.ResumeLayout(false);
            this.detailstable.ResumeLayout(false);
            this.detailstable.PerformLayout();
            this.buttonholder.ResumeLayout(false);
            this.tabview.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox detailsgroup;
        private System.Windows.Forms.TableLayoutPanel detailstable;
        private System.Windows.Forms.Label methodnamelabel;
        private System.Windows.Forms.TextBox methodnametextbox;
        private System.Windows.Forms.FlowLayoutPanel buttonholder;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.TextBox nametextbox;
        private System.Windows.Forms.Label hooknamelabel;
        private System.Windows.Forms.Label hooktypelabel;
        private System.Windows.Forms.TextBox hooknametextbox;
        private System.Windows.Forms.ComboBox hooktypedropdown;
        private System.Windows.Forms.Button flagbutton;
        private System.Windows.Forms.Button unflagbutton;
        private System.Windows.Forms.Button applybutton;
        private System.Windows.Forms.TabControl tabview;
        private System.Windows.Forms.TabPage hooksettingstab;
        private System.Windows.Forms.TabPage beforetab;
        private System.Windows.Forms.TabPage aftertab;
        private System.Windows.Forms.Label typenamelabel;
        private System.Windows.Forms.Label assemblylabel;
        private System.Windows.Forms.TextBox typenametextbox;
        private System.Windows.Forms.TextBox assemblytextbox;
    }
}
