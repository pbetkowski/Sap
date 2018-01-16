﻿using System;
using System.Collections.Generic;
using System.Xml;
using SAPbouiCOM.Framework;
using PowerBusiness;

namespace PowerBusiness
{
    [FormAttribute("PowerBusiness.Form1", "Form1.b1f")]
    class Form1 : UserFormBase
    {
        public Form1()
        {
        }

        /// <summary>
        /// Initialize components. Called by framework after form created.
        /// </summary>
        public override void OnInitializeComponent()
        {
            this.Grid0 = ((SAPbouiCOM.Grid)(this.GetItem("Item_0").Specific));
            this.Grid0.DoubleClickAfter += new SAPbouiCOM._IGridEvents_DoubleClickAfterEventHandler(this.Grid0_DoubleClickAfter);
            this.Grid0.PressedAfter += new SAPbouiCOM._IGridEvents_PressedAfterEventHandler(this.OnClickListener);
            this.Edit1 = ((SAPbouiCOM.EditText)(this.GetItem("Item_1").Specific));
            this.Edit1.DoubleClickBefore += new SAPbouiCOM._IEditTextEvents_DoubleClickBeforeEventHandler(this.Edit1_DoubleClickBefore);
            this.StaticText0 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_2").Specific));
            this.Edit2 = ((SAPbouiCOM.EditText)(this.GetItem("Item_3").Specific));
            this.Edit2.DoubleClickBefore += new SAPbouiCOM._IEditTextEvents_DoubleClickBeforeEventHandler(this.Edit2_DoubleClickBefore);
            this.StaticText1 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_4").Specific));
            this.StaticText2 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_5").Specific));
            this.Edit3 = ((SAPbouiCOM.EditText)(this.GetItem("Item_6").Specific));
            this.Edit3.DoubleClickBefore += new SAPbouiCOM._IEditTextEvents_DoubleClickBeforeEventHandler(this.Edit3_DoubleClickBefore);
            this.StaticText3 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_7").Specific));
            this.Edit4 = ((SAPbouiCOM.EditText)(this.GetItem("Item_8").Specific));
            this.Edit4.DoubleClickBefore += new SAPbouiCOM._IEditTextEvents_DoubleClickBeforeEventHandler(this.Edit4_DoubleClickBefore);
            this.StaticText4 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_9").Specific));
            this.Edit5 = ((SAPbouiCOM.EditText)(this.GetItem("Item_10").Specific));
            this.Edit5.DoubleClickBefore += new SAPbouiCOM._IEditTextEvents_DoubleClickBeforeEventHandler(this.Edit5_DoubleClickBefore);
            this.StaticText5 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_11").Specific));
            this.Edit6 = ((SAPbouiCOM.EditText)(this.GetItem("Item_12").Specific));
            this.Edit6.DoubleClickBefore += new SAPbouiCOM._IEditTextEvents_DoubleClickBeforeEventHandler(this.Edit6_DoubleClickBefore);
            this.StaticText6 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_13").Specific));
            this.Edit7 = ((SAPbouiCOM.EditText)(this.GetItem("Item_14").Specific));
            this.Edit7.DoubleClickBefore += new SAPbouiCOM._IEditTextEvents_DoubleClickBeforeEventHandler(this.Edit7_DoubleClickBefore);
            this.StaticText7 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_15").Specific));
            this.Edit8 = ((SAPbouiCOM.EditText)(this.GetItem("Item_16").Specific));
            this.Edit8.DoubleClickBefore += new SAPbouiCOM._IEditTextEvents_DoubleClickBeforeEventHandler(this.Edit8_DoubleClickBefore);
            this.FillTableButton = ((SAPbouiCOM.Button)(this.GetItem("Item_17").Specific));
            this.FillTableButton.ClickBefore += new SAPbouiCOM._IButtonEvents_ClickBeforeEventHandler(this.FillTableButton_ClickBefore);
            this.RefreshButton = ((SAPbouiCOM.Button)(this.GetItem("Item_18").Specific));
            this.RefreshButton.ClickBefore += new SAPbouiCOM._IButtonEvents_ClickBeforeEventHandler(this.ResetButton);
            this.ComboBox0 = ((SAPbouiCOM.ComboBox)(this.GetItem("Item_19").Specific));
            this.ComboBox0.ComboSelectAfter += new SAPbouiCOM._IComboBoxEvents_ComboSelectAfterEventHandler(this.ComboBox0_ComboSelectAfter);
            this.StaticText8 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_20").Specific));
            this.StaticText9 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_21").Specific));
            this.Grid1 = ((SAPbouiCOM.Grid)(this.GetItem("Item_22").Specific));
            this.StaticText10 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_23").Specific));
            this.Edit0 = ((SAPbouiCOM.EditText)(this.GetItem("Item_24").Specific));
            this.Edit0.DoubleClickBefore += new SAPbouiCOM._IEditTextEvents_DoubleClickBeforeEventHandler(this.EditText8_DoubleClickBefore);
            this.LinkedButton0 = ((SAPbouiCOM.LinkedButton)(this.GetItem("Item_25").Specific));
            this.StaticText11 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_26").Specific));
            this.Button2 = ((SAPbouiCOM.Button)(this.GetItem("Item_27").Specific));
            this.Button2.ClickBefore += new SAPbouiCOM._IButtonEvents_ClickBeforeEventHandler(this.Button2_ClickBefore);
            this.Button3 = ((SAPbouiCOM.Button)(this.GetItem("Item_28").Specific));
            this.Button3.ClickBefore += new SAPbouiCOM._IButtonEvents_ClickBeforeEventHandler(this.Button3_ClickBefore);
            this.OnCustomInitialize();



        }

        /// <summary>
        /// Initialize form event. Called by framework before form creation.
        /// </summary>
        public override void OnInitializeFormEvents()
        {

        }



        private void OnCustomInitialize()
        {

        }

        private SAPbouiCOM.Grid Grid0;
        private SAPbouiCOM.EditText Edit1;
        private SAPbouiCOM.StaticText StaticText0;
        private SAPbouiCOM.EditText Edit2;
        private SAPbouiCOM.StaticText StaticText1;
        private SAPbouiCOM.StaticText StaticText2;
        private SAPbouiCOM.EditText Edit3;
        private SAPbouiCOM.StaticText StaticText3;
        private SAPbouiCOM.EditText Edit4;
        private SAPbouiCOM.StaticText StaticText4;
        private SAPbouiCOM.EditText Edit5;
        private SAPbouiCOM.StaticText StaticText5;
        private SAPbouiCOM.EditText Edit6;
        private SAPbouiCOM.StaticText StaticText6;
        private SAPbouiCOM.EditText Edit7;
        private SAPbouiCOM.StaticText StaticText7;
        private SAPbouiCOM.EditText Edit8;
        private SAPbouiCOM.Button FillTableButton;
        private SAPbouiCOM.Button RefreshButton;
        private SAPbouiCOM.ComboBox ComboBox0;
        private SAPbouiCOM.StaticText StaticText8;
        private SAPbouiCOM.StaticText StaticText9;
        private SAPbouiCOM.Grid Grid1;
        private SAPbouiCOM.StaticText StaticText10;
        private SAPbouiCOM.EditText Edit0;
        private SAPbouiCOM.LinkedButton LinkedButton0;
        private SAPbouiCOM.StaticText StaticText11;
        private SAPbouiCOM.Button Button2;
        private SAPbouiCOM.Button Button3;
        private SAPbouiCOM.Form form;

        SqlClass SqlExecutor = new SqlClass();
        ComponentManipulation CM_Obj = new ComponentManipulation();
        Counter cntObj = new Counter();
        String dynamicColumnName;
        String SecondPar;
        String par1;
        String par2;
        String par3;
        String par4;
        String par5;
        String par6;
        String par7;
        String par8;
        Boolean isColored;
        Boolean isSorted;

        //get value from the EditText
        private void InitializeVariables()
        {
            par1 = Edit1.String;
            par2 = Edit2.String;
            par3 = Edit3.String;
            par4 = Edit4.String;
            par5 = Edit5.String;
            par6 = Edit6.String;
            par7 = Edit7.String;
            par8 = Edit8.String;
        }

        private void ResetButton(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            InitializeVariables();
            cntObj.getDate(StaticText11);
            SecondPar = "";
            //   column = columns.Add("#", SAPbouiCOM.BoFormItemTypes.it_EDIT);

            try
            {
                CM_Obj.resetTable(Edit1, Edit2, Edit3, Edit4, Edit5, Edit6, Edit7, Edit8);
                CM_Obj.cleanRows(Grid0);
            }

            catch (Exception)
            {
                Application.SBO_Application.MessageBox("Błąd przy odświeżaniu tabeli.");
            }

        }

        private void ComboBox0_ComboSelectAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            try
            {
                cntObj.getDate(StaticText11);
                CM_Obj.resetTable(Edit1, Edit2, Edit3, Edit4, Edit5, Edit6, Edit7, Edit8);
                InitializeVariables();



                //if (isColored == true)
                //{   //TODO spowalnia 
                //    CM_Obj.cleanRows(Grid0);
                //}


                if (ComboBox0.Selected.Description == "1")
                {
                    CM_Obj.changeLabel(StaticText0, StaticText1, StaticText2, StaticText3, StaticText4, StaticText5, StaticText6, StaticText7, "Indeks", "Numer surowy", "Numer gotowy", "Opis", "Magazyn", "Lokalizacja", "Kod kreskowy", "Partia klienta");
                    CM_Obj.changeMainLabel(StaticText8, "Stany na lokalizacjach");
                    CM_Obj.resetTable(Edit1, Edit2, Edit3, Edit4, Edit5, Edit6, Edit7, Edit8);
                    SqlExecutor.loadDataIntoTable(form, Grid0, par1, par2, par3, par4, par5, par6, par7, par8);


                }

                else if (ComboBox0.Selected.Description == "2")
                {
                    CM_Obj.changeMainLabel(StaticText8, "Nieprzelokalizowane detale");
                    CM_Obj.changeLabel(StaticText0, StaticText1, StaticText2, StaticText3, StaticText4, StaticText5, StaticText6, StaticText7, "Indeks", "Numer surowy", "Klient", "Magazyn", "Lokalizacja", "Kod kreskowy", "N/D", "N/D");
                    CM_Obj.resetTable(Edit1, Edit2, Edit3, Edit4, Edit5, Edit6, Edit7, Edit8);
                    SqlExecutor.detailsOnSP(form, Grid0, par1, par2, par3, par4, par5, par6);
                    // item.Visible = false;
                }

                else if (ComboBox0.Selected.Description == "3")
                {
                    CM_Obj.changeMainLabel(StaticText8, "Stany po numerze surowym");
                    CM_Obj.changeLabel(StaticText0, StaticText1, StaticText2, StaticText3, StaticText4, StaticText5, StaticText6, StaticText7, "Numer surowy", "Opis", "Klient", "N/D", "N/D", "N/D", "N/D", "N/D");
                    CM_Obj.resetTable(Edit1, Edit2, Edit3, Edit4, Edit5, Edit6, Edit7, Edit8);
                    SqlExecutor.u_DrawNoRawSumRaport(form, Grid0, par1, par2, par3);

                }

                else if (ComboBox0.Selected.Description == "4")
                {
                    CM_Obj.changeMainLabel(StaticText8, "Stany po numerze gotowym");
                    CM_Obj.changeLabel(StaticText0, StaticText1, StaticText2, StaticText3, StaticText4, StaticText5, StaticText6, StaticText7, "Numer gotowy", "Opis", "Klient", "N/D", "N/D", "N/D", "N/D", "N/D");
                    CM_Obj.resetTable(Edit1, Edit2, Edit3, Edit4, Edit5, Edit6, Edit7, Edit8);
                    SqlExecutor.u_DrawNoFinalSumRaport(form, Grid0, par1, par2, par3);


                }

                else if (ComboBox0.Selected.Description == "5")
                {
                    CM_Obj.changeMainLabel(StaticText8, "Zamówienia działu zakupów");
                    CM_Obj.changeLabel(StaticText0, StaticText1, StaticText2, StaticText3, StaticText4, StaticText5, StaticText6, StaticText7, "Numer zamówienia", "Dostawca", "Waluta", "Uwagi", "Status", "Odział", "N/D", "N/D");
                    CM_Obj.resetTable(Edit1, Edit2, Edit3, Edit4, Edit5, Edit6, Edit7, Edit8);
                    SqlExecutor.purchaseOrdersRapport(form, Grid0, par1, par2, par3, par4, par5, par6);
                    CM_Obj.fillWithColorsPurchaseOrder(Grid0, 6);
                    isColored = true;

                }

                else if (ComboBox0.Selected.Description == "6")
                {
                    CM_Obj.changeMainLabel(StaticText8, "Zamówienia magazynu chemicznego");
                    CM_Obj.changeLabel(StaticText0, StaticText1, StaticText2, StaticText3, StaticText4, StaticText5, StaticText6, StaticText7, "Numer zamówienia", "Dostawca", "Status", "Waluta", "Uwagi", "Odział", "N/D", "N/D");
                    CM_Obj.resetTable(Edit1, Edit2, Edit3, Edit4, Edit5, Edit6, Edit7, Edit8);
                    SqlExecutor.chemicalOrdersReport(form, Grid0, par1, par2, par3, par4, par5, par6);
                    CM_Obj.fillWithColorsChemicalOrders(Grid0, 3);
                    isColored = true;

                }

                else if (ComboBox0.Selected.Description == "7")
                {
                    CM_Obj.changeMainLabel(StaticText8, "Gospodarka materiałowa");
                    CM_Obj.changeLabel(StaticText0, StaticText1, StaticText2, StaticText3, StaticText4, StaticText5, StaticText6, StaticText7, "Klient", "Indeks", "Numer gotowy", "Opis", "Stan", "N/D", "N/D", "N/D");
                    CM_Obj.resetTable(Edit1, Edit2, Edit3, Edit4, Edit5, Edit6, Edit7, Edit8);
                    SqlExecutor.chemicalStocks(form, Grid0, par1, par2, par3, par4, par5);
                    CM_Obj.fillWithColorsChemicalStock(Grid0, 8);
                    isColored = true;


                }
            }

            catch (Exception e)
            {
                Application.SBO_Application.MessageBox(e.Message);

            }

        }

        private void OnClickListener(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            dynamicColumnName = pVal.ColUID;
            try
            {

                int index = Grid0.GetDataTableRowIndex(pVal.Row); //get the row number on click
                SecondPar = Grid0.DataTable.GetValue(pVal.ColUID, index).ToString();  //get the specified col/row value
                if (ComboBox0.Selected.Description == "5")
                {
                    SqlExecutor.fillSecondGridPurchase(form, Grid1, SecondPar);
                }

                else if (ComboBox0.Selected.Description == "6")
                {

                    SqlExecutor.fillSecondGridWitchChemicalDetails(form, Grid1, SecondPar);
                }

                else if (ComboBox0.Selected.Description == "7")
                {
                    SqlExecutor.fillSecondGridWitchChemicalStocks(form, Grid1, SecondPar);
                }

                else
                {
                    SqlExecutor.fillSecondGridDefault(form, Grid1, SecondPar);
                }


            }

            catch (Exception)
            {

            }

        }

        private void Edit1_DoubleClickBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            Edit1.String = SecondPar;

        }

        private void Edit2_DoubleClickBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            Edit2.String = SecondPar;

        }

        private void Edit3_DoubleClickBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            Edit3.String = SecondPar;

        }

        private void Edit4_DoubleClickBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            Edit4.String = SecondPar;

        }

        private void Edit5_DoubleClickBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            Edit5.String = SecondPar;

        }

        private void Edit6_DoubleClickBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            Edit6.String = SecondPar;

        }

        private void Edit7_DoubleClickBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            Edit7.String = SecondPar;

        }

        private void Edit8_DoubleClickBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            Edit8.String = SecondPar;

        }

        private void EditText8_DoubleClickBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            Edit0.String = SecondPar;

        }

        private void Grid0_DoubleClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            SAPbouiCOM.GridColumn column;
            column = Grid0.Columns.Item(dynamicColumnName);
            column.TitleObject.Sortable = true;

            if (isSorted == false)
            {
                Grid0.Columns.Item(dynamicColumnName).TitleObject.Sort(SAPbouiCOM.BoGridSortType.gst_Ascending);
                isSorted = true;
            }
            else
            {
                Grid0.Columns.Item(dynamicColumnName).TitleObject.Sort(SAPbouiCOM.BoGridSortType.gst_Descending);
                isSorted = false;
            }

        }

        private void FillTableButton_ClickBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            InitializeVariables();
            cntObj.getDate(StaticText11);
            SecondPar = "";
            try
            {
                if (ComboBox0.Selected.Description == "1")  //1 if "stany na lokalizacjach"
                {

                    SqlExecutor.loadDataIntoTable(form, Grid0, par1, par2, par3, par4, par5, par6, par7, par8);
                    //  Application.SBO_Application.MessageBox(Grid0.DataTable.Rows.Count.ToString());
                }

                else if (ComboBox0.Selected.Description == "2") //nieprzelokalizowane detale
                {
                    SqlExecutor.detailsOnSP(form, Grid0, par1, par2, par3, par4, par5, par6);
                }

                else if (ComboBox0.Selected.Description == "3")  //stany po numerze surowym
                {
                    SqlExecutor.u_DrawNoRawSumRaport(form, Grid0, par1, par2, par3);
                }

                else if (ComboBox0.Selected.Description == "4")  //stany po numerze gotowym
                {
                    SqlExecutor.u_DrawNoFinalSumRaport(form, Grid0, par1, par2, par3);
                }

                else if (ComboBox0.Selected.Description == "5")  //lista zamówień
                {
                    SqlExecutor.purchaseOrdersRapport(form, Grid0, par1, par2, par3, par4, par5, par6);
                    CM_Obj.fillWithColorsPurchaseOrder(Grid0, 6);

                }

                else if (ComboBox0.Selected.Description == "6")  //lista zamówień magazynu chemicznego
                {
                    SqlExecutor.chemicalOrdersReport(form, Grid0, par1, par2, par3, par4, par5, par6);
                    CM_Obj.fillWithColorsChemicalOrders(Grid0, 3);
                }

                else if (ComboBox0.Selected.Description == "7")  //gospodarka materiałowa
                {
                    SqlExecutor.chemicalStocks(form, Grid0, par1, par2, par3, par4, par5);

                }
            }

            catch (Exception)
            {
                Application.SBO_Application.MessageBox("Wybierz raport");
            }

        }

        private void Button2_ClickBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            try
            {
                SAPbouiCOM.GridColumn column;
                column = Grid0.Columns.Item(dynamicColumnName);
                column.TitleObject.Sortable = true;
                Grid0.Columns.Item(dynamicColumnName).TitleObject.Sort(SAPbouiCOM.BoGridSortType.gst_Ascending);

                //Grid0.Columns.Item("Indeks").Type = SAPbouiCOM.BoGridColumnType.gct_CheckBox; 
            }

            catch (Exception)
            {
                Application.SBO_Application.MessageBox("W fazie testów");
            }

        }

        private void Button3_ClickBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            // Application.SBO_Application.Forms.Item("ff").Close();
            // Application.SBO_Application.MessageBox(Grid0.DataTable.GetValue(8, 2).ToString());
            Application.SBO_Application.MessageBox(cntObj.countTotal(Grid0, 9).ToString());

        }





    }
}