namespace PadFootingsInsertion
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.FootingMaterialTextBox = new System.Windows.Forms.TextBox();
            this.MaterialButton = new System.Windows.Forms.Button();
            this.saveLoad1 = new Tekla.Structures.Dialog.UIControls.SaveLoad();
            this.ProfileTextBox = new System.Windows.Forms.TextBox();
            this.profileCatalog1 = new Tekla.Structures.Dialog.UIControls.ProfileCatalog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.heighttextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.structuresExtender.SetAttributeName(this.button1, null);
            this.structuresExtender.SetAttributeTypeName(this.button1, null);
            this.structuresExtender.SetBindPropertyName(this.button1, null);
            this.button1.Location = new System.Drawing.Point(713, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Insert pad footings";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.structuresExtender.SetAttributeName(this.button2, null);
            this.structuresExtender.SetAttributeTypeName(this.button2, null);
            this.structuresExtender.SetBindPropertyName(this.button2, null);
            this.button2.Location = new System.Drawing.Point(12, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Load Grid";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FootingMaterialTextBox
            // 
            this.structuresExtender.SetAttributeName(this.FootingMaterialTextBox, "Material");
            this.structuresExtender.SetAttributeTypeName(this.FootingMaterialTextBox, "String");
            this.structuresExtender.SetBindPropertyName(this.FootingMaterialTextBox, null);
            this.FootingMaterialTextBox.Location = new System.Drawing.Point(12, 107);
            this.FootingMaterialTextBox.Name = "FootingMaterialTextBox";
            this.FootingMaterialTextBox.Size = new System.Drawing.Size(151, 20);
            this.FootingMaterialTextBox.TabIndex = 3;
            this.FootingMaterialTextBox.TextChanged += new System.EventHandler(this.FootingMaterialTextBox_TextChanged);
            // 
            // MaterialButton
            // 
            this.structuresExtender.SetAttributeName(this.MaterialButton, null);
            this.structuresExtender.SetAttributeTypeName(this.MaterialButton, null);
            this.structuresExtender.SetBindPropertyName(this.MaterialButton, null);
            this.MaterialButton.Location = new System.Drawing.Point(169, 107);
            this.MaterialButton.Name = "MaterialButton";
            this.MaterialButton.Size = new System.Drawing.Size(75, 20);
            this.MaterialButton.TabIndex = 4;
            this.MaterialButton.Text = "Select...";
            this.MaterialButton.UseVisualStyleBackColor = true;
            this.MaterialButton.Click += new System.EventHandler(this.MaterialButton_Click);
            // 
            // saveLoad1
            // 
            this.structuresExtender.SetAttributeName(this.saveLoad1, null);
            this.structuresExtender.SetAttributeTypeName(this.saveLoad1, null);
            this.saveLoad1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.structuresExtender.SetBindPropertyName(this.saveLoad1, null);
            this.saveLoad1.Dock = System.Windows.Forms.DockStyle.Top;
            this.saveLoad1.HelpFileType = Tekla.Structures.Dialog.UIControls.SaveLoad.HelpFileTypeEnum.General;
            this.saveLoad1.HelpKeyword = "";
            this.saveLoad1.HelpUrl = "";
            this.saveLoad1.Location = new System.Drawing.Point(0, 0);
            this.saveLoad1.Name = "saveLoad1";
            this.saveLoad1.SaveAsText = "";
            this.saveLoad1.Size = new System.Drawing.Size(800, 43);
            this.saveLoad1.TabIndex = 5;
            this.saveLoad1.UserDefinedHelpFilePath = null;
            // 
            // ProfileTextBox
            // 
            this.structuresExtender.SetAttributeName(this.ProfileTextBox, "Profile");
            this.structuresExtender.SetAttributeTypeName(this.ProfileTextBox, "String");
            this.structuresExtender.SetBindPropertyName(this.ProfileTextBox, null);
            this.ProfileTextBox.Location = new System.Drawing.Point(12, 146);
            this.ProfileTextBox.Name = "ProfileTextBox";
            this.ProfileTextBox.Size = new System.Drawing.Size(151, 20);
            this.ProfileTextBox.TabIndex = 7;
            // 
            // profileCatalog1
            // 
            this.structuresExtender.SetAttributeName(this.profileCatalog1, null);
            this.structuresExtender.SetAttributeTypeName(this.profileCatalog1, null);
            this.profileCatalog1.BackColor = System.Drawing.Color.Transparent;
            this.structuresExtender.SetBindPropertyName(this.profileCatalog1, null);
            this.profileCatalog1.ButtonText = "Select...";
            this.profileCatalog1.Location = new System.Drawing.Point(169, 146);
            this.profileCatalog1.Name = "profileCatalog1";
            this.profileCatalog1.SelectedProfile = "";
            this.profileCatalog1.Size = new System.Drawing.Size(75, 20);
            this.profileCatalog1.TabIndex = 8;
            this.profileCatalog1.SelectClicked += new System.EventHandler(this.profileCatalog1_SelectClicked);
            this.profileCatalog1.SelectionDone += new System.EventHandler(this.profileCatalog1_SelectionDone);
            this.profileCatalog1.Load += new System.EventHandler(this.profileCatalog1_Load);
            // 
            // label1
            // 
            this.structuresExtender.SetAttributeName(this.label1, null);
            this.structuresExtender.SetAttributeTypeName(this.label1, null);
            this.label1.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.label1, null);
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select material:";
            // 
            // label2
            // 
            this.structuresExtender.SetAttributeName(this.label2, null);
            this.structuresExtender.SetAttributeTypeName(this.label2, null);
            this.label2.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.label2, null);
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Select profile:";
            // 
            // label3
            // 
            this.structuresExtender.SetAttributeName(this.label3, null);
            this.structuresExtender.SetAttributeTypeName(this.label3, null);
            this.label3.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.label3, null);
            this.label3.Location = new System.Drawing.Point(12, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Height:";
            // 
            // heighttextBox
            // 
            this.structuresExtender.SetAttributeName(this.heighttextBox, "Height");
            this.structuresExtender.SetAttributeTypeName(this.heighttextBox, "Double");
            this.structuresExtender.SetBindPropertyName(this.heighttextBox, null);
            this.heighttextBox.Location = new System.Drawing.Point(12, 185);
            this.heighttextBox.Name = "heighttextBox";
            this.heighttextBox.Size = new System.Drawing.Size(151, 20);
            this.heighttextBox.TabIndex = 11;
            // 
            // Form1
            // 
            this.structuresExtender.SetAttributeName(this, null);
            this.structuresExtender.SetAttributeTypeName(this, null);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.structuresExtender.SetBindPropertyName(this, null);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.heighttextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.profileCatalog1);
            this.Controls.Add(this.ProfileTextBox);
            this.Controls.Add(this.saveLoad1);
            this.Controls.Add(this.MaterialButton);
            this.Controls.Add(this.FootingMaterialTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button MaterialButton;
        private Tekla.Structures.Dialog.UIControls.SaveLoad saveLoad1;
        private System.Windows.Forms.TextBox ProfileTextBox;
        private System.Windows.Forms.TextBox FootingMaterialTextBox;
        private Tekla.Structures.Dialog.UIControls.ProfileCatalog profileCatalog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox heighttextBox;
    }
}

