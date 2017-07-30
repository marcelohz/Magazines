using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Magazines
{
	/// <summary>
	/// Provides a connection to the hardcoded data source
	/// </summary>
	class DataAccess
	{
        private const String _stringConnection = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source = magazines.mdb";
        //private const String _stringConnection = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = magazines.mdb";
        
		private static OleDbConnection _connection;
		private OleDbTransaction _transaction;
		
		public int GetIdentity()
		{
			OleDbDataReader dr = CreateDataReader("SELECT @@IDENTITY");
			if (!dr.HasRows)
				return 0;
			dr.Read();
			return dr.GetInt32(0);
		}

		public DataAccess()
		{
			_connection = new OleDbConnection(_stringConnection);
			_connection.Open();
		}

		public int ExecuteNonQuery(String sql)
		{
			if (_connection.State != ConnectionState.Open)
				return (-1);
			OleDbCommand cmd = new OleDbCommand(sql, _connection);
			cmd.Transaction = _transaction;
			return cmd.ExecuteNonQuery();
		}

		public OleDbDataReader CreateDataReader(String sql)
		{
			OleDbCommand cmd = new OleDbCommand(sql, _connection);
			cmd.Transaction = _transaction;
			OleDbDataReader dr = cmd.ExecuteReader();
			return dr;
		}

		public bool BeginTransaction()
		{
			bool ret;
			try
			{
				_transaction = _connection.BeginTransaction();
				ret =  true;
			}
			catch (Exception ex)
			{
				MessageBox.Show("BeginTransaction() failed: " + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
				ret = false;
			}
			return ret;
		}

		public bool RollbackTransaction()
		{
			bool ret;
			try
			{
				_transaction.Rollback();
				ret = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show("RollbackTransaction() failed: " + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
				ret = false;
			}
			return ret;
		}

		public bool CommitTransaction()
		{
			bool ret;
			try
			{
				_transaction.Commit();
				ret = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show("CommitTransaction() failed: " + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
				ret = false;
			}
			
			return ret;
		}

	}
}
