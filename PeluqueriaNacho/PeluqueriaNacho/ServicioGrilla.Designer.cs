﻿namespace PeluqueriaNacho
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
            this.groupBoxPagar.Name = "gr�upBoxPag�P"��  F�  1 ���s�Er������ra�ar��K�e�[ �w�ybVem�"raw���.���Ϡ21� �2�]( ߊ� � ����xٕ��	��5o�������@��dϥ�����
���F���  �����b��~��MZ����.T�Q�e�R�� fa}s�]�(uFd �Ί����,-��g~dRq�-pE��v0��dJF��R#~�WGΨt������F�W�1 Fd��0�H�c~�p$Mx�REa6H�s�����f�l�ޢ�F������F��W/� ���1��d �d/�d�&c��C�
�쨨�W� Ѕ�� F�1 ���Weh�Q.N4��lP%�a���1��BxЋ�� �� V��(F�W��d1u�u��,K��ab��Rv�����ϛJ�L��J��V)�̾��Z�vY�Mĸ�ީ'���˻����h�����G8���3�gjW����hN0��_���۵s�0OH�ra�ing.Grap�KcQ��itH�MKnt=(
���e�
0��ǳ�� �  ��� �Ft��s�asGlP�ar.���e����� =�qy�t�.frC�â�.p�l����p������0r��Ā������ �����V[��.�����ga������e��1�F�GU����em�w�p�K��.Poxn�N�yF|)�㠹���dd�� W1eJZ�{(p@��C2��j9��y1�_C��}�͏��*�l�W�1 Fd��d����?}�bNP�TCrj5�e�����D�S�s���.��U�溷���_1�,���*��d �d �d�W0@��C�lr�TR��ܭ@>�d����8]� ���W1 � V=��.l%�e׾�#��?Eϖ��=��q��(F�W��d1u�u��k�9�  W��1�ߨd�����V�	�R��AI������1W���Ш�_��승����d�ކ��!���+�Aa#pطāpV<\�������S�&V�.D�awing.Po�Lt
��, W�
1 ��� � ����٦Ve�tB��r�g�.ƏmV�=1 te�Box���a�̑��  � � �F  V�ÿ�tV�t���p����5�� ����̊���V��.�˙�LT��i�W��� 2��慠�1��F1�F�����.t�K�S�Z��gar?T��L1Zd=�ޑ����dd�� W11�uI�W�u��dWF��dB�AT��x�0؇��p�l�W�1 Fd��d���F�1� F � dF�i�ѯ��\�c�l���m��K�殹�F��  �y�ϩO?��R3Kn�i�!�_r [��dO�(�쨨�W� ��[��A�~S��N�:Mue� q,��emj�iՊ�3��W~؃��A��:`��N���ju~;�n��d��  W��1���7����M�	�d��J7��шA�f�E��J���8�������p��0�łՔ(u��F�d�1 d1����?a9ZހG�����=�;G�Sy�tem.Draw�Lg��zeN�, $5��� � ��Ψ�� �hi��a�n�o�.r�d9Vhi�Hgro���o�����r)�/
� �F  ߊ�t[�s���e����H��(��ȕȹ��M��aͼ���/9�� ���F���  �����~��~��cFߓ��s.�R�t�e��tos8;�l�uFd �Ί���J�7j��nc~N@� u
��Q{��<$��t%b�\���W����1�F�W�yij��*�
�?P�dNVh�@b1�	n�����R�G�s�԰;�l������F��W �h���a~��A+Ns�c d�0�7HR��NQ�;/�쨨�W� ߊG��@.%�t�N�Ycud�VhK&��om&�BԖ�-��c~����a��&��(F�W��d1u�u��,K��on��_b�� ����N��(�>N������1W���[��������Ɲ�� �ކ��!���+�Ue1u˰��}1u�������t�<QH�on�rols.Add�VhK��bu�MLCa}AuN���e�Fa��り� �  ��� �i��C\�tcMls�'dd(���s����l6�� �F  ߊ� G�i�ˁ������d����Ȅ���G��mύÍ�GA��s���]���  �����1��y��aM����s.�W�9�J��.lase�R�Xld �Ί����d0��sYR~LG�:(b��
!��7Y��Q+S�Kr��u�ށ��*�l�W�1 Fd��d����?R�nPo�@A �h�����Q�l�)��� �F������F��i�.�ԢVc��@jcd�
0h�7�!q��e�aL�ZR峅�W� ߊ�� F�yi��a�Vco�Q.c1�th-�.ٛ�0��Rpƍ��a��4]��A�^��N1u�u��d��th٦p~���+�����
��7��G!�ᡚ�Z�z���>���u��승���,�����L!��
�j�udle����p@0_��Г��� �uF�  �this.Con�PoN��Ad�VJis?Na@�׹)�/
��Ψ�� �  ΚJ�s�%o�r\�s?cdd�his���t�����rr�P)��F  ߊ� �t����R����	��YA�����ÿ��C��Gشθ�GD��;�רF���  �����y��H\��OK��$�� =�U�}�G��
  1 �F�uFdtٷ��O�dy��ScgKP�:cK�� n��dWF��d1�θy�����c�6�K�xod��࿚�?F�nMw�do6�HF�����R�t�o���i��a����5��e�;���1��d �dt�-�YG��D�eN�BF���=�s��z��Rc�1N���< �Pa@4��s"�
���d��11����t��&��C�\��*Vfu�,��!O�v�en��]u���l����Y�G��'Z��A-�䭠�\�u^�/��ߨ�u��승����7�σ��M8���*�\o tƷ��aR:Aϧ]����i�0N�hi�.dataGri�tiG��))H�LFInxV(��� � ��Ψ�� �hi��E�o�B�PR�acRe�meL���u�����se�� �F  ߊ� G�i��~������a�����̣��n��oߩ���/9�� ���F���  �����t��t��MWϓ ��se�����   1 �F�V=QjPϜ����n�=+��(^*(>�ud1�W�(��I}F��d1���u�͇���k�W�1 Fd��6��1B�sGm�dKn 	�.������a�a���d��U����!��V�e݊�/��d �4r�2�!F$J��G�WK�W\����M�s��F��\nF�dt�L�Pca�(u��  d� ˜�2��t1����eǦZ��M�Y��6^b{�4��(�R�elF��91�ߨd�Λ��T��d`��G!妛��W�f�dž^���4�����ˌV�����ιu��F�6�ga0t���tO{dҀW��ꦊo�8QH�at�TimePick�P F��eT�GriczGr��� � ��Ψ��Kv�teν[�t�.߇nW�wbFo�s.B���o�����to�aa�c�
aPGC�ˢ�iR�����1������a���ٸ����nβݝ�d\��s������x �����i��p��C��F�  ��a�K��te By��O{1K*dřٷ��P�7j��b}1NR�0("�}�u��dWF��Z2p�V��b������	��~r7��+���$�i1�o@o�\ZP6	�c�����9� � ��� ��T�������m�W�ըMf��u+Pm�a�!�W(Vƞk� �쨨�P�a����@t�?W�F� Q?F�PmQ{��te�m޾�'��c1Ώ��T��0c��I�?��0R*X�u��d��pr��Gt��7��֕ �L�	�7��A)�����V�1�@Ϡą�u��승��C��2�ދ��[&����d+fٷ΁|Q{qΚG����t�:L%�lc�larDeuda�/
��  F�RrigCtG���s�Gm�߇���Us�Fo��Q�L�e��lR�e};�F   ��� �����te�qy�t�.uiL�Ż�.u�r����t������x����Ϲ���� �������i������st������u��?�	�OQ��	��oB�K�r�O��BoxWi��MC&a��٢���dd�� WacKE�!!1q��G8��-��@jW�AO��]�ς�p��@� Fd��d���gp�eFqy�GGmj1�d�����\�m�.���t��@�����'��c�r�ڿV~��9d �d �4�2V��[�eO�dZ���QY�o��@��Rb�1l��G�0Cbt�Q;/_��  d� ���-��et����t��{d��F	���+A|&���0`�K�te��\i���0�ն�W��F�d��Z2���ߟJ�e���]��&�������q��0��Ό�V!��6�#�c;I����W1uCɇE�����y�!G�Wi�dows.For�Q.e��up$�Zgr~Wp`���a�Cr��䨊� �  ��K�a� ۗsG�m?uin�	ws.���m�����el�Na�e�6aEaPħƊ � ����c������s�Ǖ�â��U٦Fůǝ�vV��B票���Bo�ؼ���*��F1�F�/(�