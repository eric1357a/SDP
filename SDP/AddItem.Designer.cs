namespace SDP
{
    partial class AddItem
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
            this.components = new System.ComponentModel.Container();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.discount = new System.Windows.Forms.Label();
            this.product_id = new System.Windows.Forms.TextBox();
            this.Product_name = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.RichTextBox();
            this.dimension = new System.Windows.Forms.TextBox();
            this.reorderinglevel = new System.Windows.Forms.TextBox();
            this.shelf_loc = new System.Windows.Forms.TextBox();
            this.discount_tb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.TextBox();
            this.category = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbDataSet1 = new SDP.dbDataSet1();
            this.label = new System.Windows.Forms.Label();
            this.subCategory = new System.Windows.Forms.ComboBox();
            this.categorySubCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.categoryTableAdapter = new SDP.dbDataSet1TableAdapters.CategoryTableAdapter();
            this.subCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sub_CategoryTableAdapter = new SDP.dbDataSet1TableAdapters.Sub_CategoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorySubCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subCategoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(59, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Sales Department System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.ImageLocation = "home.png";
            this.pictureBox1.Location = new System.Drawing.Point(10, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(56, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Designer Home";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(381, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Add New Item";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(431, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Login As:";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.time.Location = new System.Drawing.Point(12, 441);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(41, 15);
            this.time.TabIndex = 16;
            this.time.Text = "label5";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(12, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Product ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(13, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Product Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(205, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Description:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(13, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(205, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "Dimension:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(205, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "Quantity:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(385, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 15);
            this.label11.TabIndex = 23;
            this.label11.Text = "Reordering level:";
            // 
            // discount
            // 
            this.discount.AutoSize = true;
            this.discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.discount.Location = new System.Drawing.Point(385, 170);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(58, 15);
            this.discount.TabIndex = 24;
            this.discount.Text = "Discount:";
            // 
            // product_id
            // 
            this.product_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.product_id.Location = new System.Drawing.Point(14, 135);
            this.product_id.Name = "product_id";
            this.product_id.ReadOnly = true;
            this.product_id.Size = new System.Drawing.Size(167, 21);
            this.product_id.TabIndex = 27;
            // 
            // Product_name
            // 
            this.Product_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Product_name.Location = new System.Drawing.Point(14, 185);
            this.Product_name.Name = "Product_name";
            this.Product_name.Size = new System.Drawing.Size(168, 21);
            this.Product_name.TabIndex = 28;
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.price.Location = new System.Drawing.Point(14, 243);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(168, 21);
            this.price.TabIndex = 29;
            this.price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.price_KeyPress);
            // 
            // description
            // 
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.description.Location = new System.Drawing.Point(207, 301);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(338, 137);
            this.description.TabIndex = 31;
            this.description.Text = "";
            // 
            // dimension
            // 
            this.dimension.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dimension.Location = new System.Drawing.Point(207, 134);
            this.dimension.Name = "dimension";
            this.dimension.Size = new System.Drawing.Size(157, 21);
            this.dimension.TabIndex = 32;
            // 
            // reorderinglevel
            // 
            this.reorderinglevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.reorderinglevel.Location = new System.Drawing.Point(387, 134);
            this.reorderinglevel.Name = "reorderinglevel";
            this.reorderinglevel.Size = new System.Drawing.Size(158, 21);
            this.reorderinglevel.TabIndex = 33;
            this.reorderinglevel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.price_KeyPress);
            // 
            // shelf_loc
            // 
            this.shelf_loc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.shelf_loc.Location = new System.Drawing.Point(207, 243);
            this.shelf_loc.Name = "shelf_loc";
            this.shelf_loc.Size = new System.Drawing.Size(157, 21);
            this.shelf_loc.TabIndex = 34;
            // 
            // discount_tb
            // 
            this.discount_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.discount_tb.Location = new System.Drawing.Point(387, 185);
            this.discount_tb.Name = "discount_tb";
            this.discount_tb.Size = new System.Drawing.Size(158, 21);
            this.discount_tb.TabIndex = 36;
            this.discount_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.price_KeyPress);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(387, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(468, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 38;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(387, 257);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 23);
            this.button3.TabIndex = 39;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(15, 285);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 15);
            this.label13.TabIndex = 40;
            this.label13.Text = "Category";
            // 
            // quantity
            // 
            this.quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.quantity.Location = new System.Drawing.Point(207, 185);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(157, 21);
            this.quantity.TabIndex = 41;
            this.quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.price_KeyPress);
            // 
            // category
            // 
            this.category.AutoCompleteCustomSource.AddRange(new string[] {
            "Sofas And Chairs",
            "Bedroom Furniture",
            "Living Room Furniture",
            "Dining Room Furniture",
            "Tables",
            "Beds and Mattresses",
            "Office Furniture",
            "Kids Furniture",
            "Bathroom Furniture"});
            this.category.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.category.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.category.DataSource = this.categoryBindingSource;
            this.category.DisplayMember = "Category_Name";
            this.category.FormattingEnabled = true;
            this.category.Location = new System.Drawing.Point(14, 304);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(167, 20);
            this.category.TabIndex = 42;
            this.category.SelectedIndexChanged += new System.EventHandler(this.category_SelectedIndexChanged);
            this.category.FontChanged += new System.EventHandler(this.category_FontChanged);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.dbDataSet1BindingSource;
            // 
            // dbDataSet1BindingSource
            // 
            this.dbDataSet1BindingSource.DataSource = this.dbDataSet1;
            this.dbDataSet1BindingSource.Position = 0;
            // 
            // dbDataSet1
            // 
            this.dbDataSet1.DataSetName = "dbDataSet1";
            this.dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label.Location = new System.Drawing.Point(205, 224);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(88, 15);
            this.label.TabIndex = 43;
            this.label.Text = "Shelf Location:";
            // 
            // subCategory
            // 
            this.subCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.subCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.subCategory.DataSource = this.categorySubCategoryBindingSource;
            this.subCategory.DisplayMember = "Category_Name";
            this.subCategory.FormattingEnabled = true;
            this.subCategory.Location = new System.Drawing.Point(15, 360);
            this.subCategory.Name = "subCategory";
            this.subCategory.Size = new System.Drawing.Size(167, 20);
            this.subCategory.TabIndex = 45;
            // 
            // categorySubCategoryBindingSource
            // 
            this.categorySubCategoryBindingSource.DataMember = "CategorySub Category";
            this.categorySubCategoryBindingSource.DataSource = this.categoryBindingSource;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(16, 341);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 15);
            this.label12.TabIndex = 44;
            this.label12.Text = "Sub Category";
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // subCategoryBindingSource
            // 
            this.subCategoryBindingSource.DataMember = "Sub_Category";
            this.subCategoryBindingSource.DataSource = this.dbDataSet1BindingSource;
            // 
            // sub_CategoryTableAdapter
            // 
            this.sub_CategoryTableAdapter.ClearBeforeFill = true;
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 464);
            this.Controls.Add(this.subCategory);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label);
            this.Controls.Add(this.category);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.discount_tb);
            this.Controls.Add(this.shelf_loc);
            this.Controls.Add(this.reorderinglevel);
            this.Controls.Add(this.dimension);
            this.Controls.Add(this.description);
            this.Controls.Add(this.price);
            this.Controls.Add(this.Product_name);
            this.Controls.Add(this.product_id);
            this.Controls.Add(this.discount);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "AddItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Item";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorySubCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subCategoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label discount;
        private System.Windows.Forms.TextBox product_id;
        private System.Windows.Forms.TextBox Product_name;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.TextBox dimension;
        private System.Windows.Forms.TextBox reorderinglevel;
        private System.Windows.Forms.TextBox shelf_loc;
        private System.Windows.Forms.TextBox discount_tb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox subCategory;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.BindingSource dbDataSet1BindingSource;
        private dbDataSet1 dbDataSet1;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private dbDataSet1TableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.BindingSource subCategoryBindingSource;
        private dbDataSet1TableAdapters.Sub_CategoryTableAdapter sub_CategoryTableAdapter;
        private System.Windows.Forms.BindingSource categorySubCategoryBindingSource;
    }
}