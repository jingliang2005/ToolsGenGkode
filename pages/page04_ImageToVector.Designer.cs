﻿using System.Collections.Generic;
using System.Drawing;

namespace ToolsGenGkode.pages
{
    partial class page04_ImageToVector
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
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownKoefPalitra = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.cbNegative = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonSelectFile = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.btShowOriginalImage = new System.Windows.Forms.Button();
            this.SkeletonizationFilter = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKoefPalitra)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(259, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(346, 19);
            this.label3.TabIndex = 9;
            this.label3.Tag = "_koefficientToBlackWhile_";
            this.label3.Text = "Коэффициент разделения на черный и белый цвет";
            // 
            // numericUpDownKoefPalitra
            // 
            this.numericUpDownKoefPalitra.Location = new System.Drawing.Point(203, 69);
            this.numericUpDownKoefPalitra.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownKoefPalitra.Name = "numericUpDownKoefPalitra";
            this.numericUpDownKoefPalitra.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownKoefPalitra.TabIndex = 8;
            this.numericUpDownKoefPalitra.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.numericUpDownKoefPalitra.ValueChanged += new System.EventHandler(this.numericUpDownKoefPalitra_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(616, 38);
            this.button1.TabIndex = 19;
            this.button1.Tag = "_showImageStep1_";
            this.button1.Text = "Показать изображение с примененным преобразованием по коеффициенту";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbNegative
            // 
            this.cbNegative.AutoSize = true;
            this.cbNegative.Location = new System.Drawing.Point(203, 46);
            this.cbNegative.Name = "cbNegative";
            this.cbNegative.Size = new System.Drawing.Size(172, 17);
            this.cbNegative.TabIndex = 0;
            this.cbNegative.Tag = "_reversColor_";
            this.cbNegative.Text = "Применить инверсия цветов";
            this.cbNegative.UseVisualStyleBackColor = true;
            this.cbNegative.CheckedChanged += new System.EventHandler(this.checkBoxUseFilter1_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(14, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(618, 46);
            this.button2.TabIndex = 12;
            this.button2.Tag = "_showResultGetContur_";
            this.button2.Text = "Показать результат полученного контура из изображения";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.GetResult_Click);
            // 
            // buttonSelectFile
            // 
            this.buttonSelectFile.Location = new System.Drawing.Point(595, 13);
            this.buttonSelectFile.Name = "buttonSelectFile";
            this.buttonSelectFile.Size = new System.Drawing.Size(39, 21);
            this.buttonSelectFile.TabIndex = 28;
            this.buttonSelectFile.Text = "...";
            this.buttonSelectFile.UseVisualStyleBackColor = true;
            this.buttonSelectFile.Click += new System.EventHandler(this.buttonSelectFile_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 29;
            this.label6.Tag = "_SelectFile_";
            this.label6.Text = "Выбор файла:";
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(97, 13);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(492, 20);
            this.textBoxFileName.TabIndex = 27;
            // 
            // btShowOriginalImage
            // 
            this.btShowOriginalImage.Image = global::ToolsGenGkode.Properties.Resources.arrow_refresh;
            this.btShowOriginalImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btShowOriginalImage.Location = new System.Drawing.Point(14, 46);
            this.btShowOriginalImage.Name = "btShowOriginalImage";
            this.btShowOriginalImage.Size = new System.Drawing.Size(171, 49);
            this.btShowOriginalImage.TabIndex = 30;
            this.btShowOriginalImage.Tag = "_showOriginalImage_";
            this.btShowOriginalImage.Text = "Показать оригинальное изображение";
            this.btShowOriginalImage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btShowOriginalImage.UseVisualStyleBackColor = true;
            this.btShowOriginalImage.Click += new System.EventHandler(this.btShowOriginalImage_Click);
            // 
            // SkeletonizationFilter
            // 
            this.SkeletonizationFilter.AutoSize = true;
            this.SkeletonizationFilter.Location = new System.Drawing.Point(168, 152);
            this.SkeletonizationFilter.Name = "SkeletonizationFilter";
            this.SkeletonizationFilter.Size = new System.Drawing.Size(280, 17);
            this.SkeletonizationFilter.TabIndex = 31;
            this.SkeletonizationFilter.Tag = "_UseSkeleton_";
            this.SkeletonizationFilter.Text = "Использовать утоньшение контуров изобразения";
            this.SkeletonizationFilter.UseVisualStyleBackColor = true;
            this.SkeletonizationFilter.CheckedChanged += new System.EventHandler(this.SkeletonizationFilter_CheckedChanged);
            // 
            // page04_ImageToVector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SkeletonizationFilter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDownKoefPalitra);
            this.Controls.Add(this.cbNegative);
            this.Controls.Add(this.btShowOriginalImage);
            this.Controls.Add(this.buttonSelectFile);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxFileName);
            this.Name = "page04_ImageToVector";
            this.Size = new System.Drawing.Size(645, 240);
            this.Tag = "_page04_";
            this.Load += new System.EventHandler(this.page03_ImageModification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKoefPalitra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.NumericUpDown numericUpDownKoefPalitra;
        public System.Windows.Forms.CheckBox cbNegative;
        private System.Windows.Forms.Button buttonSelectFile;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Button btShowOriginalImage;
        private System.Windows.Forms.CheckBox SkeletonizationFilter;

        public int NextPage { get; set; }
        public Bitmap pageImageIN { get; set; }
        public Bitmap pageImageNOW { get; set; }
        public List<GroupPoint> pageVectorIN { get; set; }
        public List<GroupPoint> pageVectorNOW { get; set; }



    }
}
