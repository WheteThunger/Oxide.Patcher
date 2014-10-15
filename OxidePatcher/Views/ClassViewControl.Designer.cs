﻿namespace OxidePatcher.Views
{
    partial class ClassViewControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassViewControl));
            this.detailsgroup = new System.Windows.Forms.GroupBox();
            this.detailstable = new System.Windows.Forms.TableLayoutPanel();
            this.declarationtextbox = new System.Windows.Forms.TextBox();
            this.declarationlabel = new System.Windows.Forms.Label();
            this.typenamelabel = new System.Windows.Forms.Label();
            this.typenametextbox = new System.Windows.Forms.TextBox();
            this.splitter = new System.Windows.Forms.SplitContainer();
            this.objectview = new System.Windows.Forms.TreeView();
            this.imagelist = new System.Windows.Forms.ImageList(this.components);
            this.detailsgroup.SuspendLayout();
            this.detailstable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitter)).BeginInit();
            this.splitter.Panel1.SuspendLayout();
            this.splitter.SuspendLayout();
            this.SuspendLayout();
            // 
            // detailsgroup
            // 
            this.detailsgroup.Controls.Add(this.detailstable);
            this.detailsgroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.detailsgroup.Location = new System.Drawing.Point(0, 0);
            this.detailsgroup.Name = "detailsgroup";
            this.detailsgroup.Size = new System.Drawing.Size(721, 75);
            this.detailsgroup.TabIndex = 0;
            this.detailsgroup.TabStop = false;
            this.detailsgroup.Text = "Class Details";
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
            this.detailstable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailstable.Location = new System.Drawing.Point(3, 16);
            this.detailstable.Name = "detailstable";
            this.detailstable.RowCount = 2;
            this.detailstable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.detailstable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.detailstable.Size = new System.Drawing.Size(715, 56);
            this.detailstable.TabIndex = 0;
            // 
            // declarationtextbox
            // 
            this.declarationtextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.declarationtextbox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.declarationtextbox.Location = new System.Drawing.Point(156, 31);
            this.declarationtextbox.Name = "declarationtextbox";
            this.declarationtextbox.ReadOnly = true;
            this.declarationtextbox.Size = new System.Drawing.Size(556, 23);
            this.declarationtextbox.TabIndex = 4;
            // 
            // declarationlabel
            // 
            this.declarationlabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.declarationlabel.Location = new System.Drawing.Point(3, 28);
            this.declarationlabel.Name = "declarationlabel";
            this.declarationlabel.Size = new System.Drawing.Size(147, 28);
            this.declarationlabel.TabIndex = 2;
            this.declarationlabel.Text = "Declaration:";
            this.declarationlabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // typenamelabel
            // 
            this.typenamelabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typenamelabel.Location = new System.Drawing.Point(3, 0);
            this.typenamelabel.Name = "typenamelabel";
            this.typenamelabel.Size = new System.Drawing.Size(147, 28);
            this.typenamelabel.TabIndex = 0;
            this.typenamelabel.Text = "Fully Qualified Typename:";
            this.typenamelabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // typenametextbox
            // 
            this.typenametextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typenametextbox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typenametextbox.Location = new System.Drawing.Point(156, 3);
            this.typenametextbox.Name = "typenametextbox";
            this.typenametextbox.ReadOnly = true;
            this.typenametextbox.Size = new System.Drawing.Size(556, 23);
            this.typenametextbox.TabIndex = 3;
            // 
            // splitter
            // 
            this.splitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitter.Location = new System.Drawing.Point(0, 75);
            this.splitter.Name = "splitter";
            // 
            // splitter.Panel1
            // 
            this.splitter.Panel1.Controls.Add(this.objectview);
            this.splitter.Size = new System.Drawing.Size(721, 419);
            this.splitter.SplitterDistance = 239;
            this.splitter.TabIndex = 1;
            // 
            // objectview
            // 
            this.objectview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectview.ImageIndex = 0;
            this.objectview.ImageList = this.imagelist;
            this.objectview.Location = new System.Drawing.Point(0, 0);
            this.objectview.Name = "objectview";
            this.objectview.SelectedImageIndex = 0;
            this.objectview.Size = new System.Drawing.Size(239, 419);
            this.objectview.TabIndex = 0;
            this.objectview.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.objectview_NodeMouseClick);
            // 
            // imagelist
            // 
            this.imagelist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagelist.ImageStream")));
            this.imagelist.TransparentColor = System.Drawing.Color.Transparent;
            this.imagelist.Images.SetKeyName(0, "script_lightning.png");
            this.imagelist.Images.SetKeyName(1, "Method_636.png");
            this.imagelist.Images.SetKeyName(2, "Method-Friend_638.png");
            this.imagelist.Images.SetKeyName(3, "MethodInstance.png");
            this.imagelist.Images.SetKeyName(4, "Method-Private_640.png");
            this.imagelist.Images.SetKeyName(5, "Method-Protected_639.png");
            this.imagelist.Images.SetKeyName(6, "Method-Sealed_637.png");
            this.imagelist.Images.SetKeyName(7, "Method-Shortcut_641.png");
            this.imagelist.Images.SetKeyName(8, "Property_501.png");
            this.imagelist.Images.SetKeyName(9, "Property-Friend_503.png");
            this.imagelist.Images.SetKeyName(10, "PropertyGridEditorPart_6041.png");
            this.imagelist.Images.SetKeyName(11, "PropertyIcon.png");
            this.imagelist.Images.SetKeyName(12, "Property-Private_505.png");
            this.imagelist.Images.SetKeyName(13, "Property-Shortcut_506.png");
            this.imagelist.Images.SetKeyName(14, "ExtensionMethod_9571.png");
            this.imagelist.Images.SetKeyName(15, "Field-Friend_543.png");
            this.imagelist.Images.SetKeyName(16, "FieldIcon.png");
            this.imagelist.Images.SetKeyName(17, "Field-Private_545.png");
            this.imagelist.Images.SetKeyName(18, "Field-Protected_544.png");
            this.imagelist.Images.SetKeyName(19, "Field-Sealed_542.png");
            // 
            // ClassViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitter);
            this.Controls.Add(this.detailsgroup);
            this.Name = "ClassViewControl";
            this.Size = new System.Drawing.Size(721, 494);
            this.detailsgroup.ResumeLayout(false);
            this.detailstable.ResumeLayout(false);
            this.detailstable.PerformLayout();
            this.splitter.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitter)).EndInit();
            this.splitter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox detailsgroup;
        private System.Windows.Forms.SplitContainer splitter;
        private System.Windows.Forms.TableLayoutPanel detailstable;
        private System.Windows.Forms.Label typenamelabel;
        private System.Windows.Forms.Label declarationlabel;
        private System.Windows.Forms.TextBox typenametextbox;
        private System.Windows.Forms.TextBox declarationtextbox;
        private System.Windows.Forms.TreeView objectview;
        private System.Windows.Forms.ImageList imagelist;
    }
}
