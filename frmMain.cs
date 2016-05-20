using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;

public partial class frmMain : Form
{
    private List<clsZipCode> mZipCodeList = new List<clsZipCode>();
    public static void Main()
    {
        frmMain main = new frmMain();
        Application.Run(main);
    }

    public frmMain()
    {
        InitializeComponent();
        string pathFileName = Path.Combine(Application.StartupPath, "zipcodes_1990Census.txt");
        string input;

        using (StreamReader sr = new StreamReader(pathFileName))
        {
            input = sr.ReadLine();
            while (input != null) 
            {
                clsZipCode zipCode = new clsZipCode();
                zipCode.Deserialize(input);
                mZipCodeList.Add(zipCode);
                input = sr.ReadLine();
            }
            sr.Close();
        }

        radAscending.Checked = true;
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void btnDisplayAllEntries_Click(object sender, EventArgs e)
    {
        Cursor.Current = Cursors.WaitCursor;
        lstDisplayEntries.Items.Clear();

        clsZipCodeComparer zipcodeComparer;
        if (radAscending.Checked == true) 
        {
             zipcodeComparer= new clsZipCodeComparer(true, false);
        } 
        else
        {
            zipcodeComparer = new clsZipCodeComparer(false, false);
        }
        
        mZipCodeList.Sort(zipcodeComparer);
        
        foreach(clsZipCode zipCode in mZipCodeList) 
        {
            addItemToList(zipCode);
        }
        Cursor.Current = Cursors.Default;
    }

    private void btnFilterByZipCode_Click(object sender, EventArgs e)
    {
        Cursor.Current = Cursors.WaitCursor;
        lstDisplayEntries.Items.Clear();

        string zipCodeToSearch = txtZipCodeSearch.Text.Trim();
        
        if (zipCodeToSearch.Length == 0)
        {
            return;
        }
        bool found = false;

        int start = 0;
        int end = mZipCodeList.Count;
        int middle = (start + end) / 2;

        while (start <= end)
        {
            if (String.Compare(mZipCodeList[middle].ZipCode, zipCodeToSearch) == 0)
            {
                found = true;
                break;
            }
            else if (String.Compare(mZipCodeList[middle].ZipCode, zipCodeToSearch) < 0)
            {
                start = middle + 1;
                middle = (end + start) / 2;
            }
            else
            {
                end = middle - 1;
                middle = (start + end) / 2;
            }
        }

        if (found == true)
        {
            addItemToList(mZipCodeList[middle]);
        }
       
        if (found == false)
        {
            MessageBox.Show("Zip Code not found.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        Cursor.Current = Cursors.Default;
    }

    private void btnFilterByCity_Click(object sender, EventArgs e)
    {
        Cursor.Current = Cursors.WaitCursor;
        lstDisplayEntries.Items.Clear();

        string cityToSearch = txtCitySearch.Text.ToLower();
        if (cityToSearch.Length == 0)
        {
            return;
        }

        bool found = false;

        clsZipCodeComparer filteredResultsComparer;

        if (radAscending.Checked == true)
        {
            filteredResultsComparer = new clsZipCodeComparer(true, true);
        }
        else
        {
            filteredResultsComparer = new clsZipCodeComparer(false, true);
        }

        List<clsZipCode> filteredResults = new List<clsZipCode>();

        foreach (clsZipCode zipCode in mZipCodeList)
        {
            if (zipCode.City.ToLower() == cityToSearch)
            {
                found = true;
                filteredResults.Add(zipCode);
            }
        }

        if (found == false)
        {
            MessageBox.Show("City not found.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            Cursor.Current = Cursors.Default;
            return;
        }

        filteredResults.Sort(filteredResultsComparer);

        foreach (clsZipCode zipCode in filteredResults)
        {
            addItemToList(zipCode);
        }

        if (found == false)
        {
            MessageBox.Show("City not found.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        Cursor.Current = Cursors.Default;
    }

    private void addItemToList(clsZipCode zipCode)
    {
        int padding = 7;
        string result = zipCode.ZipCode.PadRight(padding)
                  + zipCode.State.PadRight(padding)
                  + zipCode.City.PadRight(padding * 3)
                  + Math.Round(zipCode.Latitude, 2).ToString().PadRight(padding * 2)
                  + Math.Round(zipCode.Longitude, 2).ToString();

        lstDisplayEntries.Items.Add(result);
    }
}