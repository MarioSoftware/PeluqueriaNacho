namespace PeluqueriaNacho
{
    partial class ServicioGrilla
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonCalcularGanancia = new System.Windows.Forms.Button();
            this.textBoxGanancia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxProductos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerHasta = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonCalcularDeuda = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDeuda = new System.Windows.Forms.TextBox();
            this.comboBoxFiltroTrabajos = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonAplicarGasto = new System.Windows.Forms.Button();
            this.labelGastos = new System.Windows.Forms.Label();
            this.textBoxGasto = new System.Windows.Forms.TextBox();
            this.buttonPagar = new System.Windows.Forms.Button();
            this.groupBoxPagar = new System.Windows.Forms.GroupBox();
            this.labelPagar = new System.Windows.Forms.Label();
            this.textBoxPagar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxPagar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 102);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(920, 377);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.BackColor = System.Drawing.Color.Red;
            this.buttonCerrar.Location = new System.Drawing.Point(777, 9);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(146, 23);
            this.buttonCerrar.TabIndex = 1;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = false;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lista de trabajos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(395, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Buscar por Fecha";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(398, 76);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(127, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // buttonCalcularGanancia
            // 
            this.buttonCalcularGanancia.Location = new System.Drawing.Point(40, 485);
            this.buttonCalcularGanancia.Name = "buttonCalcularGanancia";
            this.buttonCalcularGanancia.Size = new System.Drawing.Size(116, 32);
            this.buttonCalcularGanancia.TabIndex = 7;
            this.buttonCalcularGanancia.Text = "Calcular Ganancia";
            this.buttonCalcularGanancia.UseVisualStyleBackColor = true;
            this.buttonCalcularGanancia.Click += new System.EventHandler(this.buttonCalcularGanancia_Click);
            // 
            // textBoxGanancia
            // 
            this.textBoxGanancia.Enabled = false;
            this.textBoxGanancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGanancia.Location = new System.Drawing.Point(40, 527);
            this.textBoxGanancia.Multiline = true;
            this.textBoxGanancia.Name = "textBoxGanancia";
            this.textBoxGanancia.Size = new System.Drawing.Size(116, 26);
            this.textBoxGanancia.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 535);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "$";
            // 
            // comboBoxProductos
            // 
            this.comboBoxProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProductos.FormattingEnabled = true;
            this.comboBoxProductos.Location = new System.Drawing.Point(193, 74);
            this.comboBoxProductos.Name = "comboBoxProductos";
            this.comboBoxProductos.Size = new System.Drawing.Size(144, 21);
            this.comboBoxProductos.TabIndex = 12;
            this.comboBoxProductos.SelectionChangeCommitted += new System.EventHandler(this.comboBoxProductos_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(190, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Buscar por producto";
            // 
            // dateTimePickerHasta
            // 
            this.dateTimePickerHasta.CustomFormat = "";
            this.dateTimePickerHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerHasta.Location = new System.Drawing.Point(550, 75);
            this.dateTimePickerHasta.Name = "dateTimePickerHasta";
            this.dateTimePickerHasta.Size = new System.Drawing.Size(127, 20);
            this.dateTimePickerHasta.TabIndex = 15;
            this.dateTimePickerHasta.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(547, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Hasta";
            // 
            // buttonCalcularDeuda
            // 
            this.buttonCalcularDeuda.Location = new System.Drawing.Point(762, 485);
            this.buttonCalcularDeuda.Name = "buttonCalcularDeuda";
            this.buttonCalcularDeuda.Size = new System.Drawing.Size(114, 32);
            this.buttonCalcularDeuda.TabIndex = 18;
            this.buttonCalcularDeuda.Text = "Calcular Deuda";
            this.buttonCalcularDeuda.UseVisualStyleBackColor = true;
            this.buttonCalcularDeuda.Click += new System.EventHandler(this.buttonCalcularDeuda_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(735, 534);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "$";
            // 
            // textBoxDeuda
            // 
            this.textBoxDeuda.BackColor = System.Drawing.Color.Red;
            this.textBoxDeuda.Enabled = false;
            this.textBoxDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDeuda.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxDeuda.Location = new System.Drawing.Point(760, 532);
            this.textBoxDeuda.Multiline = true;
            this.textBoxDeuda.Name = "textBoxDeuda";
            this.textBoxDeuda.Size = new System.Drawing.Size(116, 26);
            this.textBoxDeuda.TabIndex = 19;
            // 
            // comboBoxFiltroTrabajos
            // 
            this.comboBoxFiltroTrabajos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFiltroTrabajos.FormattingEnabled = true;
            this.comboBoxFiltroTrabajos.Items.AddRange(new object[] {
            "TODOS",
            "EFECTIVO",
            "TARGETA",
            "CREDITO",
            "DEUDAS"});
            this.comboBoxFiltroTrabajos.Location = new System.Drawing.Point(3, 74);
            this.comboBoxFiltroTrabajos.Name = "comboBoxFiltroTrabajos";
            this.comboBoxFiltroTrabajos.Size = new System.Drawing.Size(147, 21);
            this.comboBoxFiltroTrabajos.TabIndex = 21;
            this.comboBoxFiltroTrabajos.SelectionChangeCommitted += new System.EventHandler(this.comboBoxFiltroTrabajos_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Buscar por FILTROS";
            // 
            // buttonAplicarGasto
            // 
            this.buttonAplicarGasto.Location = new System.Drawing.Point(234, 485);
            this.buttonAplicarGasto.Name = "buttonAplicarGasto";
            this.buttonAplicarGasto.Size = new System.Drawing.Size(104, 32);
            this.buttonAplicarGasto.TabIndex = 23;
            this.buttonAplicarGasto.Text = "Aplicar GASTOS";
            this.buttonAplicarGasto.UseVisualStyleBackColor = true;
            this.buttonAplicarGasto.Visible = false;
            this.buttonAplicarGasto.Click += new System.EventHandler(this.buttonAplicarGasto_Click);
            // 
            // labelGastos
            // 
            this.labelGastos.AutoSize = true;
            this.labelGastos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGastos.Location = new System.Drawing.Point(218, 535);
            this.labelGastos.Name = "labelGastos";
            this.labelGastos.Size = new System.Drawing.Size(19, 18);
            this.labelGastos.TabIndex = 25;
            this.labelGastos.Text = "$";
            this.labelGastos.Visible = false;
            // 
            // textBoxGasto
            // 
            this.textBoxGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGasto.Location = new System.Drawing.Point(243, 527);
            this.textBoxGasto.Multiline = true;
            this.textBoxGasto.Name = "textBoxGasto";
            this.textBoxGasto.Size = new System.Drawing.Size(81, 26);
            this.textBoxGasto.TabIndex = 24;
            this.textBoxGasto.Visible = false;
            // 
            // buttonPagar
            // 
            this.buttonPagar.Location = new System.Drawing.Point(459, 485);
            this.buttonPagar.Name = "buttonPagar";
            this.buttonPagar.Size = new System.Drawing.Size(218, 25);
            this.buttonPagar.TabIndex = 26;
            this.buttonPagar.Text = "Abonar Pago";
            this.buttonPagar.UseVisualStyleBackColor = true;
            this.buttonPagar.Visible = false;
            this.buttonPagar.Click += new System.EventHandler(this.buttonPagar_Click);
            // 
            // groupBoxPagar
            // 
            this.groupBoxPagar.Controls.Add(this.labelPagar);
            this.groupBoxPagar.Controls.Add(this.textBoxPagar);
            this.groupBoxPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPagar.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.groupBoxPagar.Location = new System.Drawing.Point(459, 516);
            this.groupBoxPagar.Name = "grupBoxPagéP"…“  FÎ  1 üÓás¦ErÔıÊÅğraşarÀ½KãeŠ[ æ‹wùybVem¦"rawÒ÷ş.Ÿ‡ĞÏ 21° ­2°]( ßŠìŠ ¹ ¹¨ü†xÙ•ïØ	›ø5oáœËÜÚØâ˜é@ãædÏ¥ŠÓì‘§
¨ı¨F¨›¹  ì¨ıüÂáb·ï~ß¬MZëÚ­ë.TøQÛeÅR¨µ fa}sš]¶(uFd ŠÎŠ¹Š›Ï,-û¦g~dRqÔ-pEé•v0ÒÏdJF»úR#~ŠWGÎ¨tıËÌ÷ã¹F¨WŠ1 Fd¨¨0ñ¥HÍc~ıp$MxØREa6HŞs¥‚í¨ıf­lÙŞ¢ÆFÎı¨ı¹ŠFŠ›W/ã §±ì1Îìd ›d/§dÆ&cËÍCã
ßì¨¨ìWì Ğ……‚ Fì1 ¹ıŠWehÒQ.N4êÏlP%ÍaÉÀ¾1š£BxĞ‹ÎÓ Şú V³¶(F¨W¨Šd1uìu¨Ş,KäabÆØRv­¦£€Ï›J¹LíßJ®ÏV)¦Ì¾»ZævY¨MÄ¸İŞ©'Š­¢Ë»†Îş›h¹ù—íG8¦İø3ágjWÅ÷ü½hN0ù_¹µ¹ÛµsŞ0OH»raˆing.GrapàKcQİ÷itH¾MKnt=(
êÂüe¡
0’¡Ç³§‚ ¹  ÎÎ¹ ŠFtà‡sÆasGlPéar.ıöëeÆÅú =¨qyêtü.frCˆÃ¢Í.pölöú¦ªpØĞÇÆ˜í0rü©Ä€¶ ìì¨Š¨ ŠıŠÎìV[ÃÙ.ä¼êäëøga¾¦‘çÉéeğç1—F€GU›è¿íem·wúpİKæï.Poxn‹NˆyF|)‘ã ¹Š››dd¨¨ W1eJZÈ{(p@íëC2ËÉj9ôÏy1ˆ_CŒ©}ØÍ¾Ì*”l¨WŠ1 Fd¨¨d¹¸†Ù?}ébNPéTCrj5áeìÂÎæíDıSµsŞŞô.ˆU´æº·ùĞŞ_1õ,ŠŠô*ãÆd ›d ¨dŠW0@„ÆC‹lrTR¾¦Ü­@>¢dšÒµ¨8]Á ¹ıŠW1 › V=áÙ.l%Èe×¾#¾?EÏ–šÎ=Šªq³¶(F¨W¨Šd1uìu¨…kã9¨  WŠ¨1ìß¨dãÁ›ÏáVÊ	‡RºÚAI‚¨ìßì¨1WÎŠìĞ¨Á_ÎììŠ¹ŠÎìıd¹Ş†‡ê!íáÛ+ğAa#pØ·ÄpV<\ÕÎı÷üÿìSÓ&V’.Dawing.PoáLt
¾ª, WÙ
1 ¨›¨ ¨ ›ü†áÙ¦VeátB–røgË.ÆmVŠ=1 teğBoxëøşa¾Ì‘§‚  ¨ ¹ ¹F  V—Ã¿„tVátÛçğ¾pÍÚú„5‡ò ¤ìÄŞÌŠŸµûVÏå.î¯Ë™¥LT„ùiò¸ W¸‹µ 2ş¡æ… ¨1¹¨F1ŠFÎ›Ï¥ê.tüKüSÅZØégar?TòL1Zd=ŠŞ‘” ››dd¨¨ W11”uI¨W›uŠ›dWF¹…dBÏAT‡¯xç0Ø‡ ‚p”l¨WŠ1 Fd¨¨d¹ãÁF§1¨ F ¨ dFüi¿Ñ¯ıü\c­lÏÿğm©K²æ®¹—FÄŞ  ŸyÙÏ©O?ª¾R3KnÜiò!ì_r [›™dOÕ(ßì¨¨ìWì ßŞ[áûA¸~Sú¼NÏ:Mue› q,ûŞemjıiÕŠ3âW~ØƒÀAßü:`ëÚNÅìÏju~;¸n… dÎ¨  WŠ¨1¸—á7â¬ÚØÚMä	dıèJ7üí¡ÑˆAéf€E„ŸJŒü©8­£ ÅëÙÀp£³0ëÅ‚Õ”(u¨¹F¹d¨1 d1Šíà‡?a9ZŞ€Gğãíì=Š;GßSyŒtem.DrawáLgÛğzeN×, $5³¶‚ ¨ ›¨Î¨Š¨ íhiÀaönŞoä.rÎd9VhiûHgroÎéÛo´¾ËÍér)³/
¹ ¹F  ßŠìŠt[ğs·Ëç€eØÔäÙH¯ì(í¤ÃÈ•È¹¸üMÄØaÍ¼ØÇ÷/9ŠŠ ¨ı¨F¨›¹  ¸à´û„Ë~÷ü~ÆÀcFß“¤ğs.õRêtÆeéûtos8;òl›uFd ŠÎŠ¹ŠÏJÒ7jËçnc~N@• u
üÒQ{ŞŞ<$öÒt%bŞ\ÕÁ¨WŠÎìÎ1¹F¨WŞyijËç*í¾
Ù?PìdNVhá@b1ü	n‚áëR¯G­sŞÔ°;ÁlÎı¨ı¹ŠFŠ›W ¸hÃÈâa~€¸A+Ns•c d 0Â7HRÈÏNQÇ;/õì¨¨ìWì ßŠGàá@.%£të²NÙYcud“VhK&¦Éom&ÅBÔ–¹-‚¸c~şœŒaÀç&³¶(F¨W¨Šd1uìu¨Ş,KËonØç_bâ¾ì äšÓÒ·Néš(ô€>N¨¨ìßì¨1WÎŠ¸[–ûâ¢¸ØöÆ¹ ±Ş†‡ê!íáÛ+ğUe1uË°³ã}1u›Îı¹¹¨ìtÂ<QH¼on‹rols.Add VhKû·bušMLCa}AuNéÉÌeıFa’³ã‚Š¨ ¹  ÎÎ¹ ŞiûÀC\ÄtcMls¦'dd(Ïñğsâ‚ËÈíl6¡“ ¹F  ßŠìŠ Gñiê¦ËŞÉçÆÀÉd±¸ÂÒÈ„¨­üGşámÏÃ§GAâËsü¼¡]…±¹  ì¨ı¨Š¨1¹¨yÃÀaMÕÏ£õs.ØWì9ŞJáû.lase“R’Xld ŠÎŠ¹Š››d0àásYR~LGÉ:(bÉß
!ÂÒ7YöÇQ+SÅKrœ£uıŞ¿Ç*”l¨WŠ1 Fd¨¨d¹¸†Ù?RçnPoä@A  h¥ŒÀäéQ¸lÿ)‘¶“ ìFÎı¨ı¹ŠFŠÏi¿.éÔ¢Vc @jcdß
0há7„!qÅÒe€aLœZRå³…ÆWì ßŠ¨¨ F¸yiêóaÅVco×Q.c1ì‚th-Ù.Ù›‹0¢RpÆ›‚aØÏ4]éÕAé^³§N1uìu¨ŠdÎ¨thÙ¦p~¢‹ú+ •úı
ü–7¹ÚG!Üá¡šœZëzœƒ÷>õ¨ìuÎììŠ¹ŠÎì©,ğÙÀ­öL!úö
êjÉudleÂğûÀp@0_‰ÇĞ“¹¨ì ŠuFß  ßthis.ConüPoNû·AdÆVJis?Na@í×¹)³/
›¨Î¨Š¨ ¹  ÎšJğs„%oæšr\Æs?cdd his•ûìt¸ÄéírréP)¢“F  ßŠìŠ ¹tñáûÀRÅÕüØ	‚ûYAı¨‚ÏÓÃ¿âìCŞéGØ´Î¸¥GD›ƒ;…×¨F¨›¹  ì¨ı¨ŠüyğûH\Ë‡OKÁŞ$£á =¹Ué}ÙG³…
  1 ßF›uFdtÂ‡Ù·äÚOŞdy¨ªScgKPÒ:cKäÚ n§±dWF¹Šd1ŠÎ¸yá„½¸cí6çKŞxodµ¨à¿šÇ?FánMwûdo6ûHF£ƒÛüR¯tœoÙÒíi£Àa¸æ©üØ5ÉÉe¢;§±ì1Îìd ›dtà-ÙYGŠ—D¾eNŠBF©úá­=£sšŠzïæRc£1Nì“Ï< ïPa@4âÅs"§
›ÎßdÎì11ŠÎÎÎtÂá&ÄÔC¨\µŠ*VfuŸ,ûŞ!OÀvşenâé]u šúl¸†ÒÈYÊGú–'Z²üA-ää­ €\éu^Õ/ ìß¨ìuÎììŠ¹ŠÆŸ¤7íÏƒÀÚM8øöü*ü\o tÆ·Á½aR:AÏ§]´íğé iĞ0N‹hiŒ.dataGriìtiGÿ¨))H«LFInxV(³¶‚ ¨ ›¨Î¨Š¨ íhiÀEëoßBç–PRÍacReûmeLÚàöu¸ÆÌËäse¡“ ¹F  ßŠìŠ Gñiê¦ïœ~ßËÊÅ¾éaëâúŞÉÌ£¾ånËñoß©‚Ç÷/9ŠŠ ¨ı¨F¨›¹  ¸à´û„Útêıtæ—MWÏ“ ­õse°…Š¨¨   1 ßF›V=QjPÏœÌöØÖnÚ=+ıü(^*(>±ud1¨W›(§±I}F¹Šd1Š‹¢uúÍ‡£€“k‚WŠ1 Fd¨ø6ğºÏ1BñsGm¦dKn 	ÿ.Šœåû™a¸aíÉğdš‹Uıì¼íË!ØÒV¥eİŠ÷/Îìd ›4rá2Ë!F$JÙŞGÀWK‘W\»û¦ŠM¡sÑèFüü\nF®dtí²LéPcaÉ(u¨Š  dŠ Ëœ–2¸t1ù—šeÇ¦ZæßMûYÎÅ6^b{€4êÏ(‚RêelF‘…91ìß¨dìÎ›ËğTéšd`¤ÈG!å¦›–¢WçfÀdÅ¾^Œ¦€4Œ© ŠõËŒV ï” ÎÎ¹u¨¹Fé6ága0tŠÊñtO{dÒ€W²îê¦ŠoØ8QH»atšTimePickíP FéíeTƒGriczGr³¶‚ ¨ ›¨Î¨ÚúKvøteÎ½[êtÏ.ß‡nWÅwbFoús.BÎíío¢ÎÈßütoæaaõcì
aPGC‘Ë¢ÉiR¢“¨¨Î1Š›¨Šœáaí©ŠèÂÙ¸©åıánÎ²İâd\ØÇs¦‰íüùöx ¸í¥üèçiŞépÄ‡C¶±Fì¹  ¹¨aØKşéte ByŒŞO{1K*dÅ™Ù·ìÔPÖ7jÄéb}1NRÙ0("…}›uŠ›dWFéØZ2pŞV½µbüÇÀ›‡ı	ÿì~r7¦Ë+ô®$Åi1ëo@oÊ\ZP6	ìc¸³…9ı ì Š›¹ ¼‡T¼ü¸¹ùÙÏmâWÃÕ¨Mfâu+PmÈaê!ÆW(VÆkä ßì¨¨¼Pºa‹ÏÛñ@t¡?Wğ³FÅ Q?FÔPmQ{ÌËteÃmŞ¾–'…©c1Îš‹TÃå0cáØIú?éÙ0R*XÆu¨ŠdÎ¨prÜéGtì¬ñ7¸‹Ö• ğLì	ˆ7›ÔA)û¦€®Vä1@Ï Ä…ÆuÎììŠ¹ŠÎC¾´2øŞ‹ÎÊ[&üü·ád+fÙ·Î|Q{qÎšG²÷¹ê¹tŞ:L%lcŠlarDeuda³/
¨¹  FÎRrigCtG¨èñsüGm•ß‡æÎçUs·FoœƒQ·LËeäÎlRÈe};‚F   ›¹¹ ¼œÃÜéte¨qyêtü.uiL›Å»Ù.uörôû¦ºtÒÏÊÅÎüxíÅÃÿÏ¹¨é§‚ ŠıŠÎìÚØiş¼ü¨èàst©åóßÃæuöÿ?ì	œOQ•ø	¡ûoBöK¨rÅOêçBoxWi“ÉMC&aÀÙ¢§±›dd¨¨ WacKEÚ!!1qñÏG8„ì-öİ@jWÅAOâ]éÏ‚ì‚pûä@§ Fd¨¨d¹ìÃgpüeFqyûGGmj1ád£ˆ¦Î\¯m¿.èÎít£Î@¨ü©öÄ'Ú×c­ríÚ¿V~ÕÁ9d ›d ¨4Ø2VŠù[šeOÑdZ¢ìç»QYŠoÇ@¦ÄRb 1lø¿GÆ0CbtÔQ;/_¨Š  dŠ ›-˜­etŠ½—tÏå{dáÕF	ÿ¦ì+A|&âíÒ0`K¨teŞÊ\i‹û0£Õ¶±W¹¨Fßd­ÉZ2éü©ßŸJûeƒı¥]›ç»&ÀŠ£ØôÙÀq¹©0öÄÎŒìV!ç÷6ø#éc;IŠ¹¨ÎW1uCÉ‡E¼íü¨ŸyÙ!GÑWi‘dows.ForåQ.eúöup$Zgr~Wp`çÃØaïCr€…ä¨Š¨ ¹  œKïaŞ Û—sGÏm?uinì	ws.ıöëm¿ÀæËêel¨Naûeõ6aEaPÄ§ÆŠ ¹ ¹¨¨cÃÍéŞÎÛsí©Ç•ìÃ¢¨çUÙ¦FÅ¯ÇâvVÒŞBç¥¨íÃíBo´Ø¼ïËú*”‚F1ŠF“/(Æ