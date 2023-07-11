namespace Restaurant_Point_Of_Sale
{
    public partial class Form1 : Form
    {

        // Unit price for each drinks and fast foods

        double UnitFries = 18.0, UnitBurger = 60.0, UnitSalad = 10.0, UnitPizza = 75.0, UnitChicken = 50.0, UnitCheese = 35.0;

        double UnitCola = 30.0, UnitTea = 25.0, UnitWater = 16.50, UnitSoda = 27.75, UnitICE = 38.0, UnitSouffle = 42.0;

        // Variables for each of them.
        double FriesPrc, BurgerPrc, SaladPrc, PizzaPrc, CheesePrc, ChickenPrc;
        double ColaPrc, TeaPrc, WaterPrc, SodaPrc, ICEprc, SoufflePrc;
        double SubTotal = 0, total = 0, tax = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void Datelbl_Click(object sender, EventArgs e)
        {

        }

        private void FriesCb_CheckedChanged(object sender, EventArgs e)
        {
            if (FriesCb.Checked)
            {
                FriesTb.Enabled = true;
            }
            else
            {
                FriesTb.Enabled = false;
                FriesTb.Text = "0";
            }
        }

        private void BurgerCb_CheckedChanged(object sender, EventArgs e)
        {

            if (BurgerCb.Checked)
            {
                BurgerTb.Enabled = true;
            }
            else
            {
                BurgerTb.Enabled = false;
                BurgerTb.Text = "0";
            }
        }

        private void SaladCb_CheckedChanged(object sender, EventArgs e)
        {

            if (SaladCb.Checked)
            {
                SaladTb.Enabled = true;
            }
            else
            {
                SaladTb.Enabled = false;
                SaladTb.Text = "0";
            }
        }

        private void PizzaCb_CheckedChanged(object sender, EventArgs e)
        {
            if (PizzaCb.Checked)
            {
                PizzaTb.Enabled = true;
            }
            else
            {
                PizzaTb.Enabled = false;
                PizzaTb.Text = "0";
            }
        }

        private void Closelbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ChickenCb_CheckedChanged(object sender, EventArgs e)
        {
            if (ChickenCb.Checked)
            {
                ChickenTb.Enabled = true;
            }
            else
            {
                ChickenTb.Enabled = false;
                ChickenTb.Text = "0";
            }
        }

        private void CheeseCb_CheckedChanged(object sender, EventArgs e)
        {
            if (CheeseCb.Checked)
            {
                CheeseTb.Enabled = true;
            }
            else
            {
                CheeseTb.Enabled = false;
                CheeseTb.Text = "0";
            }
        }

        private void ColaCb_CheckedChanged(object sender, EventArgs e)
        {
            if (ColaCb.Checked)
            {
                ColaTb.Enabled = true;
            }
            else
            {
                ColaTb.Enabled = false;
                ColaTb.Text = "0";
            }
        }

        private void TeaCb_CheckedChanged(object sender, EventArgs e)
        {
            if (TeaCb.Checked)
            {
                TeaTb.Enabled = true;
            }
            else
            {
                TeaTb.Enabled = false;
                TeaTb.Text = "0";
            }
        }

        private void WaterCb_CheckedChanged(object sender, EventArgs e)
        {
            if (WaterCb.Checked)
            {
                WaterTb.Enabled = true;
            }
            else
            {
                WaterTb.Enabled = false;
                WaterTb.Text = "0";
            }
        }

        private void SodaCb_CheckedChanged(object sender, EventArgs e)
        {
            if (SodaCb.Checked)
            {
                SodaTb.Enabled = true;
            }
            else
            {
                SodaTb.Enabled = false;
                SodaTb.Text = "0";
            }
        }

        private void IceCreamCb_CheckedChanged(object sender, EventArgs e)
        {
            if (IceCreamCb.Checked)
            {
                IceCreamTb.Enabled = true;
            }
            else
            {
                IceCreamTb.Enabled = false;
                IceCreamTb.Text = "0";
            }
        }

        private void SouffleCb_CheckedChanged(object sender, EventArgs e)
        {
            if (SouffleCb.Checked)
            {
                SouffleTb.Enabled = true;
            }
            else
            {
                SouffleTb.Enabled = false;
                SouffleTb.Text = "0";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FriesPrc = UnitFries * Convert.ToDouble(FriesTb.Text);
            BurgerPrc = UnitBurger * Convert.ToDouble(BurgerTb.Text);
            SaladPrc = UnitSalad * Convert.ToDouble(SaladTb.Text);
            PizzaPrc = UnitPizza * Convert.ToDouble(PizzaTb.Text);
            ChickenPrc = UnitChicken * Convert.ToDouble(ChickenTb.Text);
            CheesePrc = UnitCheese * Convert.ToDouble(CheeseTb.Text);
            // Price Calculation For Drinks and Dessert
            ColaPrc = UnitCola * Convert.ToDouble(ColaTb.Text);
            TeaPrc = UnitTea * Convert.ToDouble(TeaTb.Text);
            WaterPrc = UnitWater * Convert.ToDouble(WaterTb.Text);
            SodaPrc = UnitSoda * Convert.ToDouble(SodaTb.Text);
            ICEprc = UnitICE * Convert.ToDouble(IceCreamTb.Text);
            SoufflePrc = UnitSouffle * Convert.ToDouble(SouffleTb.Text);
            ReceiptTb.Clear();
            ReceiptTb.AppendText(Environment.NewLine);
            ReceiptTb.AppendText("\t\t\tCodeSpace Restaurant" + Environment.NewLine);
            ReceiptTb.AppendText("\t\t\t****************************" + Environment.NewLine);

            if (FriesCb.Checked)
            {
                ReceiptTb.AppendText("\tFries: " + FriesPrc + "Rs" + Environment.NewLine);
                SubTotal += FriesPrc;
                SubTotallbl.Text = "" + SubTotal;
            }

            if (BurgerCb.Checked)
            {
                ReceiptTb.AppendText("\tBurger: " + BurgerPrc + "Rs" + Environment.NewLine);
                SubTotal += BurgerPrc;
                SubTotallbl.Text = "" + SubTotal;
            }

            if (SaladCb.Checked)
            {
                ReceiptTb.AppendText("\tSalad: " + SaladPrc + "Rs" + Environment.NewLine);
                SubTotal += SaladPrc;
                SubTotallbl.Text = "" + SubTotal;
            }

            if (PizzaCb.Checked)
            {
                ReceiptTb.AppendText("\tPizza: " + PizzaPrc + "Rs" + Environment.NewLine);
                SubTotal += PizzaPrc;
                SubTotallbl.Text = "" + SubTotal;
            }

            if (ChickenCb.Checked)
            {
                ReceiptTb.AppendText("\tChicken: " + ChickenPrc + "Rs" + Environment.NewLine);
                SubTotal += ChickenPrc;
                SubTotallbl.Text = "" + SubTotal;
            }

            if (CheeseCb.Checked)
            {
                ReceiptTb.AppendText("\tCheese: " + CheesePrc + "Rs" + Environment.NewLine);
                SubTotal += CheesePrc;
                SubTotallbl.Text = "" + SubTotal;
            }

            if (ColaCb.Checked)
            {
                ReceiptTb.AppendText("\tCola: " + ColaPrc + "Rs" + Environment.NewLine);
                SubTotal += ColaPrc;
                SubTotallbl.Text = "" + SubTotal;
            }

            if (TeaCb.Checked)
            {
                ReceiptTb.AppendText("\tTea: " + TeaPrc + "Rs" + Environment.NewLine);
                SubTotal += TeaPrc;
                SubTotallbl.Text = "" + SubTotal;
            }

            if (WaterCb.Checked)
            {
                ReceiptTb.AppendText("\tWater: " + WaterPrc + "Rs" + Environment.NewLine);
                SubTotal += WaterPrc;
                SubTotallbl.Text = "" + SubTotal;
            }

            if (SodaCb.Checked)
            {
                ReceiptTb.AppendText("\tSoda: " + SodaPrc + "Rs" + Environment.NewLine);
                SubTotal += SodaPrc;
                SubTotallbl.Text = "" + SubTotal;
            }

            if (IceCreamCb.Checked)
            {
                ReceiptTb.AppendText("\tIce Cream: " + ICEprc + "Rs" + Environment.NewLine);
                SubTotal += ICEprc;
                SubTotallbl.Text = "" + SubTotal;
            }

            if (SouffleCb.Checked)
            {
                ReceiptTb.AppendText("\tSouffle: " + SoufflePrc + "Rs" + Environment.NewLine);
                SubTotal += SoufflePrc;
                SubTotallbl.Text = "" + SubTotal;
            }

            tax = SubTotal * 0.20;
            total = SubTotal + tax;
            taxlbl.Text = "Rs " + tax;
            totallbl.Text = "Rs " + total;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FriesCb.Checked = false;
            BurgerCb.Checked = false;
            SaladCb.Checked = false;
            ChickenCb.Checked = false;
            PizzaCb.Checked = false;
            CheeseCb.Checked = false;

            WaterCb.Checked = false;
            TeaCb.Checked = false;
            IceCreamCb.Checked = false;
            ColaCb.Checked = false;
            SouffleCb.Checked = false;
            SodaCb.Checked = false;

            tax = 0;
            total = 0;
            SubTotal = 0;

            SubTotallbl.Text = "" + SubTotal;
            taxlbl.Text = "Rs " + tax;
            totallbl.Text = "Rs " + total;

            if (FriesCb.Checked)
            {
                FriesPrc = 0;
            }

            if (BurgerCb.Checked)
            {
                BurgerPrc = 0;
            }

            if (SaladCb.Checked)
            {
                SaladPrc = 0;
            }

            if (PizzaCb.Checked)
            {
                PizzaPrc = 0;
            }

            if (ChickenCb.Checked)
            {
                ChickenPrc = 0;
            }

            if (CheeseCb.Checked)
            {
                CheesePrc = 0;
            }

            if (ColaCb.Checked)
            {
                ColaPrc = 0;
            }

            if (TeaCb.Checked)
            {
                TeaPrc = 0;
            }

            if (WaterCb.Checked)
            {
                WaterPrc = 0;
            }

            if (SodaCb.Checked)
            {
                SodaPrc = 0;
            }

            if (IceCreamCb.Checked)
            {
                ICEprc = 0;
            }

            if (SouffleCb.Checked)
            {
                SoufflePrc = 0;
            }

            ReceiptTb.Text = "";

        }
    }
}