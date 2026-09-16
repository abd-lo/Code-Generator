using FastColoredTextBoxNS;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CodeGenCrud.Form1;

namespace CodeGenCrud
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		#region Vars

		public struct stVars
		{
			public string Type;
			public string Name;
		}

		List<stVars> VarsNamesAndTypes;
		List<stVars> VarsNamesAndTypesWithNoID;

		string AllVarsUserInput;
		string TableName;
		string FuncName;
		string BusClassName;
		string DataClassName;

		#endregion
		/*
		public int LicenseClassID { set; get; }
		public string ClassName { set; get; }
		public string ClassDescription { set; get; }
		public byte MinimumAllowedAge { set; get; }
		public byte DefaultValidityLength { set; get; }
		public float ClassFees { set; get; }
		*/

		//int PersonID,string FirstName,float Fees

		private string _GetVarsWithoutSetAndGet(string Input)
		{
			var Lines = Input.Split('\n');
			List<string> Test = new List<string>();
			string t = "";

			foreach (var Line in Lines)
			{
				Line.Trim();

				t = Line
				.Replace("public ", "")
				.Replace("private ", "");

				t = t.Substring(0, t.IndexOf('{')).Trim();
				Test.Add(t);
			}

			return string.Join(", ", Test);
		}


		private void _FillVars()
		{
			if (rdNormalVars.Checked)
			{
				AllVarsUserInput = rtxtVars.Text.Trim();
			}

			else
				AllVarsUserInput = _GetVarsWithoutSetAndGet(rtxtVars.Text.Trim());


			TableName = txtTableName.Text.Trim();
			BusClassName = txtBusClassName.Text.Trim();
			FuncName = txtFuncName.Text.Trim();
			DataClassName = txtDataAccessClassName.Text.Trim();
			_GetVarsList();
		}

		public void _GetVarsList()
		{
			VarsNamesAndTypes = new List<stVars>();
			VarsNamesAndTypesWithNoID = new List<stVars>();

			var VarNameWithType = AllVarsUserInput.Split(',');
			int Counter = 0;

			foreach (var part in VarNameWithType)
			{
				var VarNameWithTypeTrimmed = part.Trim();
				var pieces = VarNameWithTypeTrimmed.Split(' ');

				if (pieces.Length == 2)
				{
					stVars v = new stVars
					{
						Type = pieces[0].Trim(),
						Name = pieces[1].Trim()
					};

					if (Counter != 0)
					{
						VarsNamesAndTypesWithNoID.Add(v);
					}

					VarsNamesAndTypes.Add(v);
				}
				Counter++;
			}
		}

		#region Constructors

		private string _GetDefaultValuesAccordingToVarType(string Type)
		{
			string Output = "";


			switch (Type)
			{
				case "string":
					Output = "\"\"";
					break;

				case "int":
					Output = "0";
					break;

				case "short":
					Output = "(short)0";
					break;

				case "float":
					Output = "0f";
					break;

				case "double":
					Output = "0.0";
					break;

				case "DateTime":
					Output = "DateTime.Now";
					break;

				case "byte":
					Output = "0";
					break;

				default:
					break;
			}
			return Output;
		}


		private string _GetPublicConstructorVars()
		{
			string output = "";

			foreach (var item in VarsNamesAndTypes)
			{
				output += "this." + item.Name + " = " + _GetDefaultValuesAccordingToVarType(item.Type) + ";\n";
			}

			return output;
		}

		public string GeneratePublicConstructor()
		{
			string output = $@"
public {BusClassName}()
{{
		{_GetPublicConstructorVars()}
}}";

			return output;
		}
		/*
		 		clsApplication(int ApplicationID, int ApplicantPersonID, int ApplicationTypeID, DateTime ApplicationDate, DateTime LastStatusDate, enApplicationStatus ApplicationStatus, float PaidFees, int CreatedByUserID)
		{

			this.ApplicationID = ApplicationID;
			this.ApplicantPersonID = ApplicantPersonID;
			this.ApplicationTypeID = ApplicationTypeID;
			this.CreatedByUserID = CreatedByUserID;
			this.ApplicationDate = ApplicationDate;
			this.LastStatusDate = LastStatusDate;
			this.PaidFees = PaidFees;
			this.ApplicationStatus = ApplicationStatus;
			this.Mode = enMode.Update;
			this.UserInfo=clsUser.FindUserByUserID(CreatedByUserID);
			this.ApplicationTypeInfo = clsApplicationType.FindApplicationTypeByID(ApplicationTypeID);


		}
		*/

		private string _GetPrivateConstuctorsVars()
		{
			string Output = "";

			foreach (var item in VarsNamesAndTypes)
			{
				Output += "this." + item.Name + "=" + item.Name + ";\n";
			}

			return Output;
		}


		public string GeneratePrivateConstructor()
		{
			string Output = $@"
{BusClassName}({AllVarsUserInput})
{{
		{_GetPrivateConstuctorsVars()}

}}";

			return Output;
		}

		#endregion


		#region GetAll

		public string GenerateGetAllData()
		{
			string GetAllFunc = $@"
public static DataTable GetAll{TableName}()
{{
	DataTable dt = new DataTable();
	SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

	string query = @""SELECT * FROM {TableName}"";

	SqlCommand command = new SqlCommand(query, connection);

	try
	{{
		connection.Open();

		SqlDataReader reader = command.ExecuteReader();

		if (reader.HasRows)
		{{
			dt.Load(reader);
		}}
	}}
	catch (Exception ex)
	{{
		// Console.WriteLine(""Error: "" + ex.Message);
	}}
	finally
	{{
		connection.Close();
	}}

	return dt;
}}";

			return GetAllFunc;
		}

		public string GenerateGetAllBus()
		{
			string GetAllFunc = $@"
public static DataTable GetAll{TableName}()
{{
	return {DataClassName}.GetAll{TableName}();
}}";

			return GetAllFunc;
		}

		#endregion

		#region AddNewData

		private string _GetAddNewFuncDataParameters()
		{
			string Output = "";

			foreach (var item in VarsNamesAndTypesWithNoID)
			{
				Output += item.Type + " " + item.Name + ", ";
			}

			Output = Output.TrimEnd(' ', '\t', '\n', ',');
			return Output;
		}

		private string _GetCommandsWithoutIDString()
		{
			StringBuilder sb = new StringBuilder();

			foreach (var item in VarsNamesAndTypesWithNoID)
			{
				sb.AppendLine($"command.Parameters.AddWithValue(\"@{item.Name}\", {item.Name});");
			}

			return sb.ToString();
		}

		private string _GetInsertIntoQuery()
		{
			string VarsName = string.Join(", ", VarsNamesAndTypesWithNoID.Select(v => v.Name));
			string VarsNameWithAt = "@" + string.Join(", @", VarsNamesAndTypesWithNoID.Select(v => v.Name));

			string query = $@"
INSERT INTO {TableName}
({VarsName})
VALUES
({VarsNameWithAt})

SELECT SCOPE_IDENTITY();";

			return query;
		}

		public string GenerateAddNewData()
		{
			string func = $@"
public static int AddNew{FuncName}({_GetAddNewFuncDataParameters()})
{{
	SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
	try
	{{
		string query = @""{_GetInsertIntoQuery().Replace("\"", "\"\"")}"";

		SqlCommand command = new SqlCommand(query, connection);

		// add parameters safely
{_GetCommandsWithoutIDString().TrimEnd()}
		connection.Open();
		int ID = Convert.ToInt32(command.ExecuteScalar());
		return ID;
	}}
	catch (Exception ex)
	{{
		Console.WriteLine(""Error Adding New {FuncName}: "" + ex.Message);
		return -1;
	}}
	finally
	{{
		connection.Close();
	}}
}}";

			return func;
		}

		private string _GetAddNewBusParameters()
		{
			string Output = "";
			foreach (var item in VarsNamesAndTypesWithNoID)
			{
				Output += "this." + item.Name + ", ";
			}

			Output = Output.TrimEnd(' ', '\t', '\n', ',');
			return Output;
		}

		public string GenerateAddNewBus()
		{
			string func = $@"
bool _AddNew{FuncName}()
{{
	this.{VarsNamesAndTypes[0].Name} = {DataClassName}.AddNew{FuncName}({_GetAddNewBusParameters()});
	return (this.{VarsNamesAndTypes[0].Name} != -1);
}}";

			return func;
		}

		#endregion

		#region Delete

		public string GenerateDeleteData()
		{
			stVars FirstItem = VarsNamesAndTypes[0];

			string func = $@"
public static bool Delete{FuncName}({FirstItem.Type} {FirstItem.Name})
{{
	SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
	try
	{{
		string query = @""DELETE FROM {TableName}
WHERE {FirstItem.Name} = @{FirstItem.Name}"";

		SqlCommand command = new SqlCommand(query, connection);

		// add parameters safely
		command.Parameters.AddWithValue(""@{FirstItem.Name}"", {FirstItem.Name});

		connection.Open();
		int rowsAffected = command.ExecuteNonQuery();

		return (rowsAffected > 0);
	}}
	catch (Exception ex)
	{{
		// log the error or show message
		Console.WriteLine(""Error Deleting record: "" + ex.Message);
		return false;
	}}
	finally
	{{
		connection.Close();
	}}
}}";

			return func;
		}

		public string GenerateDeleteBus()
		{
			string func = $@"
public static bool Delete{FuncName}({VarsNamesAndTypes[0].Type} {VarsNamesAndTypes[0].Name})
{{
	return {DataClassName}.Delete{FuncName}({VarsNamesAndTypes[0].Name});
}}";

			return func;
		}

		#endregion

		#region Update

		private string _GetCommandsWithIDString()
		{
			StringBuilder sb = new StringBuilder();

			foreach (var item in VarsNamesAndTypes)
			{
				sb.AppendLine($"command.Parameters.AddWithValue(\"@{item.Name}\", {item.Name});");
			}

			return sb.ToString();
		}

		private string _GetSetVariablesString()
		{
			StringBuilder sb = new StringBuilder();

			foreach (var item in VarsNamesAndTypesWithNoID)
			{
				sb.AppendLine($"{item.Name} = @{item.Name},");
			}

			string result = sb.ToString().TrimEnd('\r', '\n', ',');
			return result;
		}

		public string GenerateUpdateData()
		{
			string func = $@"
public static bool Update{FuncName}({AllVarsUserInput})
{{
	SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
	try
	{{
		string query = @""UPDATE {TableName}
SET
{_GetSetVariablesString()}
WHERE {VarsNamesAndTypes[0].Name} = @{VarsNamesAndTypes[0].Name};"";

	SqlCommand command = new SqlCommand(query, connection);

	// add parameters safely
	{_GetCommandsWithIDString().TrimEnd()}
	connection.Open();
	int rowsAffected = command.ExecuteNonQuery();

	return (rowsAffected > 0);
}}
	catch (Exception ex)
	{{
		// log the error or show message
		Console.WriteLine(""Error updating {FuncName}: "" + ex.Message);
return false;
	}}
	finally
	{{
	
		connection.Close();
	}}

}}";

			return func;
		}

		private string _GetUpdateParameters()
		{
			string Output = "";
			foreach (var item in VarsNamesAndTypes)
			{
				Output += "this." + item.Name + ", ";
			}

			Output = Output.TrimEnd(' ', '\t', '\n', ',');
			return Output;
		}

		public string GenerateUpdateBus()
		{
			string func = $@"
bool _Update{FuncName}()
{{
	bool IsUpdated = {DataClassName}.Update{FuncName}({_GetUpdateParameters()});
	return IsUpdated;
}}";

			return func;
		}

		#endregion

		#region Save

		public string GenerateSaveBus()
		{
			string func = $@"
public bool Save()
{{
	switch (this.Mode)
	{{
		case enMode.AddNew:
			if (_AddNew{FuncName}())
			{{
				this.Mode = enMode.Update;
				return true;
			}}
			break;

		case enMode.Update:
			if (_Update{FuncName}())
				return true;
			break;
	}}
	return false;
}}";

			return func;
		}

		#endregion

		private string _GetFindByIDDataFuncParameters()
		{
			string Output = VarsNamesAndTypes[0].Type + " " + VarsNamesAndTypes[0].Name + ", ";

			foreach (var item in VarsNamesAndTypesWithNoID)
			{
				Output += "ref " + item.Type + " " + item.Name + ", ";
			}

			Output = Output.TrimEnd(' ', '\t', '\n', ',');
			return Output;
		}

		private string _GetFillReaderString()
		{
			StringBuilder sb = new StringBuilder();

			foreach (var item in VarsNamesAndTypesWithNoID)
			{
				string Type = item.Type;
				string Name = item.Name;
				switch (Type)
				{
					case "int":
						sb.AppendLine($@"{Name} = reader[""{Name}""] != DBNull.Value ? Convert.ToInt32(reader[""{Name}""]) : -1;");
						break;

					case "byte":
						sb.AppendLine($@"{Name} = reader[""{Name}""] != DBNull.Value? Convert.ToByte(reader[""{Name}""]): (byte)0;");
						break;

					case "short":
						sb.AppendLine($@"{Name} = reader[""{Name}""] != DBNull.Value ? Convert.ToInt16(reader[""{Name}""]) : (short)-1;");
						break;

					case "string":
						sb.AppendLine($@"{Name} = reader[""{Name}""] != DBNull.Value ? reader[""{Name}""].ToString() : string.Empty;");
						break;

					case "DateTime":
						sb.AppendLine($@"{Name} = reader[""{Name}""] != DBNull.Value ? Convert.ToDateTime(reader[""{Name}""]) : DateTime.MinValue;");
						break;

					case "double":
						sb.AppendLine($@"{Name} = reader[""{Name}""] != DBNull.Value ? Convert.ToDouble(reader[""{Name}""]) : -1.0;");
						break;

					case "float":
						sb.AppendLine($@"{Name} = reader[""{Name}""] != DBNull.Value ? Convert.ToSingle(reader[""{Name}""]) : -1f;");
						break;

					case "bool":
						sb.AppendLine($@"{Name} = reader[""{Name}""] != DBNull.Value ? Convert.ToBoolean(reader[""{Name}""]) : false;");
						break;

					default:
						break;
				}
			}

			return sb.ToString().TrimEnd();
		}

		public string GenerateFindByIDData()
		{
			string idName = VarsNamesAndTypes[0].Name;
			string func = $@"
public static bool Find{FuncName}ByID({_GetFindByIDDataFuncParameters()})
{{
	bool IsFound = false;
	SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

	string query = @""SELECT * FROM {TableName} WHERE {idName} = @{idName}"";

	SqlCommand command = new SqlCommand(query, connection);
	command.Parameters.AddWithValue($""@{idName}"", {idName});

	try
	{{
		connection.Open();

		SqlDataReader reader = command.ExecuteReader();

		if (reader.Read())
		{{
{_GetFillReaderString()}
			IsFound = true;
		}}

		reader.Close();
	}}
	catch (Exception ex)
	{{
		// Console.WriteLine(""Error: "" + ex.Message);
		IsFound = false;
	}}
	finally
	{{
		connection.Close();
	}}
	return IsFound;
}}";

			return func;
		}

		private string _GenerateVarsNamesAsParameters()
		{
			string Output = "";
			foreach (var item in VarsNamesAndTypes)
			{
				Output += item.Name + ", ";
			}
			Output = Output.TrimEnd(' ', '\t', '\n', ',');
			return Output;
		}

		private string _GenerateVarsNamesAsParametersWithRef()
		{
			string Output = "";
			int Counter = 0;

			foreach (var item in VarsNamesAndTypes)
			{
				if (Counter != 0)
					Output += "ref ";

				Output += item.Name + ", ";
				Counter++;
			}

			Output = Output.TrimEnd(' ', '\t', '\n', ',');
			return Output;
		}

		private string _GenerateDeifiningVarsWithDefaultValues()
		{
			StringBuilder sb = new StringBuilder();

			foreach (var item in VarsNamesAndTypesWithNoID)
			{
				switch (item.Type)
				{
					case "string":
						sb.AppendLine($"{item.Type} {item.Name} = \"\";");
						break;

					case "int":
						sb.AppendLine($"{item.Type} {item.Name} = 0;");
						break;

					case "short":
						sb.AppendLine($"{item.Type} {item.Name} = (short)0;");
						break;

					case "float":
						sb.AppendLine($"{item.Type} {item.Name} = 0f;");
						break;

					case "double":
						sb.AppendLine($"{item.Type} {item.Name} = 0.0;");
						break;

					case "DateTime":
						sb.AppendLine($"{item.Type} {item.Name} = DateTime.MinValue;");
						break;

					case "byte":
						sb.AppendLine($"{item.Type} {item.Name} = 0;");
						break;

					default:
						break;
				}
			}

			return sb.ToString().TrimEnd();
		}

		public string GenerateFindByIDBus()
		{
			string func = $@"
public static {BusClassName} Find{FuncName}ByID({VarsNamesAndTypes[0].Type} {VarsNamesAndTypes[0].Name})
{{
{_GenerateDeifiningVarsWithDefaultValues()}

	bool IsFound = {DataClassName}.Find{FuncName}ByID({_GenerateVarsNamesAsParametersWithRef()});

	if (IsFound)
	{{
		{BusClassName} {FuncName} = new {BusClassName}({_GenerateVarsNamesAsParameters()});
		return {FuncName};
	}}

	return null;
}}";

			return func;
		}

		private void _ChangeCheckBoxesState(bool CheckedState)
		{
			CheckBox[] checkBoxes = new CheckBox[]
			{
				chkConstructors,
				chkGetAll,
				chkAddNew,
				chkUpdate,
				chkFind,
				chkDelete,
				chkSave
			};

			foreach (var item in checkBoxes)
			{
				item.Checked = CheckedState;
			}
		}

		private void _GenerateStringsAccordingToCheckBoxes(CheckBox chk, Func<string> DataFunc, Func<string> BusFunc)
		{
			if (chk.Checked)
			{
				if (DataFunc != null)
					txtData.AppendText(DataFunc.Invoke() + "\n");


				if (BusFunc != null)
					txtBus.AppendText(BusFunc.Invoke() + "\n");
			}
		}

		private void btnGenerate_Click(object sender, EventArgs e)
		{
			_FillVars();
			txtBus.Clear();
			txtData.Clear();

			_GenerateStringsAccordingToCheckBoxes(chkConstructors, null, GeneratePublicConstructor);
			_GenerateStringsAccordingToCheckBoxes(chkConstructors, null, GeneratePrivateConstructor);

			_GenerateStringsAccordingToCheckBoxes(chkGetAll, GenerateGetAllData, GenerateGetAllBus);
			_GenerateStringsAccordingToCheckBoxes(chkAddNew, GenerateAddNewData, GenerateAddNewBus);
			_GenerateStringsAccordingToCheckBoxes(chkUpdate, GenerateUpdateData, GenerateUpdateBus);
			_GenerateStringsAccordingToCheckBoxes(chkSave, null, GenerateSaveBus);
			_GenerateStringsAccordingToCheckBoxes(chkDelete, GenerateDeleteData, GenerateDeleteBus);
			_GenerateStringsAccordingToCheckBoxes(chkFind, GenerateFindByIDData, GenerateFindByIDBus);

			tabControl1.SelectedTab = tpOutputs;
		}

		private void btnCheckAll_Click(object sender, EventArgs e)
		{
			_ChangeCheckBoxesState(true);
		}

		private void btnUnCheckAll_Click(object sender, EventArgs e)
		{
			_ChangeCheckBoxesState(false);
		}
	}
}


