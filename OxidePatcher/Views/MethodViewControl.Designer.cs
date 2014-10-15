﻿namespace OxidePatcher
{
    partial class MethodViewControl
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
            this.declarationtextbox = new System.Windows.Forms.TextBox();
            this.declarationlabel = new System.Windows.Forms.Label();
            this.typenamelabel = new System.Windows.Forms.Label();
            this.typenametextbox = new System.Windows.Forms.TextBox();
            this.buttonholder = new System.Windows.Forms.FlowLayoutPanel();
            this.hookbutton = new System.Windows.Forms.Button();
            this.gotohookbutton = new System.Windows.Forms.Button();
            this.codepanel = new System.Windows.Forms.Panel();
            this.detailsgroup.SuspendLayout();
            this.detailstable.SuspendLayout();
            this.buttonholder.SuspendLayout();
            this.SuspendLayout();
            // 
            // detailsgroup
            // 
            this.detailsgroup.Controls.Add(this.detailstable);
            this.detailsgroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.detailsgroup.Location = new System.Drawing.Point(0, 0);
            this.detailsgroup.Name = "detailsgroup";
            this.detailsgroup.Size = new System.Drawing.Size(647, 109);
            this.detailsgroup.TabIndex = 1;
            this.detailsgroup.TabStop = false;
            this.detailsgroup.Text = "Method Details";
            // 
            // detailstable
            // 
            this.detailstable.ColumnCount = 2;
            this.detailstable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.53846F));
            this.detailstable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.46154F));
            this.detailstable.Controls.Add(this.declarationtextbox, 1, 1);
            this.detailstable.Controls.Add(this.declarationlabel, 0, 1);
            this.detailstable.Controls.Add(this.typenamelabel, 0, 0);
            this.detailstable.Controls.Add(this.typenametextbox, 1, 0);
            this.detailstable.Controls.Add(this.buttonholder, 0, 2);
            this.detailstable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailstable.Location = new System.Drawing.Point(3, 16);
            this.detailstable.Name = "detailstable";
            this.detailstable.RowCount = 3;
            this.detailstable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.detailstable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.detailstable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.detailstable.Size = new System.Drawing.Size(641, 90);
            this.detailstable.TabIndex = 0;
            // 
            // declarationtextbox
            // 
            this.declarationtextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.declarationtextbox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.declarationtextbox.Location = new System.Drawing.Point(141, 30);
            this.declarationtextbox.Name = "declarationtextbox";
            this.declarationtextbox.ReadOnly = true;
            this.declarationtextbox.Size = new System.Drawing.Size(497, 23);
            this.declarationtextbox.TabIndex = 4;
            // 
            // declarationlabel
            // 
            this.declarationlabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.declarationlabel.Location = new System.Drawing.Point(3, 27);
            this.declarationlabel.Name = "declarationlabel";
            this.declarationlabel.Size = new System.Drawing.Size(132, 27);
            this.declarationlabel.TabIndex = 2;
            this.declarationlabel.Text = "Declaration:";
            this.declarationlabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // typenamelabel
            // 
            this.typenamelabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typenamelabel.Location = new System.Drawing.Point(3, 0);
            this.typenamelabel.Name = "typenamelabel";
            this.typenamelabel.Size = new System.Drawing.Size(132, 27);
            this.typenamelabel.TabIndex = 0;
            this.typenamelabel.Text = "Fully Qualified Typename:";
            this.typenamelabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // typenametextbox
            // 
            this.typenametextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typenametextbox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typenametextbox.Location = new System.Drawing.Point(141, 3);
            this.typenametextbox.Name = "typenametextbox";
            this.typenametextbox.ReadOnly = true;
            this.typenametextbox.Size = new System.Drawing.Size(497, 23);
            this.typenametextbox.TabIndex = 3;
            // 
            // buttonholder
            // 
            this.detailstable.SetColumnSpan(this.buttonholder, 2);
            this.buttonholder.Controls.Add(this.hookbutton);
            this.buttonholder.Controls.Add(this.gotohookbutton);
            this.buttonholder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonholder.Location = new System.Drawing.Point(3, 57);
            this.buttonholder.Name = "buttonholder";
            this.buttonholder.Size = new System.Drawing.Size(635, 30);
            this.buttonholder.TabIndex = 5;
            // 
            // hookbutton
            // 
            this.hookbutton.Location = new System.Drawing.Point(3, 3);
            this.hookbutton.Name = "hookbutton";
            this.hookbutton.Size = new System.Drawing.Size(111, 23);
            this.hookbutton.TabIndex = 0;
            this.hookbutton.Text = "Hook This Method";
            this.hookbutton.UseVisualStyleBackColor = true;
            this.hookbutton.Click += new System.EventHandler(this.hookbutton_Click);
            // 
            // gotohookbutton
            // 
            this.gotohookbutton.Location = new System.Drawing.Point(120, 3);
            this.gotohookbutton.Name = "gotohookbutton";
            this.gotohookbutton.Size = new System.Drawing.Size(133, 23);
            this.gotohookbutton.TabIndex = 1;
            this.gotohookbutton.Text = "Goto Hook Definition";
            this.gotohookbutton.UseVisualStyleBackColor = true;
            this.gotohookbutton.Click += new System.EventHandler(this.gotohookbutton_Click);
            // 
            // codepanel
            // 
            this.codepanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codepanel.Location = new System.Drawing.Point(0, 109);
            this.codepanel.Name = "codepanel";
            this.codepanel.Padding = new System.Windows.Forms.Padding(6);
            this.codepanel.Size = new System.Drawing.Size(647, 278);
            this.codepanel.TabIndex = 2;
            // 
            // MethodViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.codepanel);
            this.Controls.Add(this.detailsgroup);
            this.Name = "MethodViewControl";
            this.Size = new System.Drawing.Size(647, 387);
            this.detailsgroup.ResumeLayout(false);
            this.detailstable.ResumeLayout(false);
            this.detailstable.PerformLayout();
            this.buttonholder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox detailsgroup;
        private System.Windows.Forms.TableLayoutPanel detailstable;
        private System.Windows.Forms.TextBox declarationtextbox;
        private System.Windows.Forms.Label declarationlabel;
        private System.Windows.Forms.Label typenamelabel;
        private System.Windows.Forms.TextBox typenametextbox;
        private System.Windows.Forms.Panel codepanel;
        private System.Windows.Forms.FlowLayoutPanel buttonholder;
        private System.Windows.Forms.Button hookbutton;
        private System.Windows.Forms.Button gotohookbutton;
    }
}
