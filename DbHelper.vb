Imports MySql.Data.MySqlClient

Module DbHelper
    Sub CreateTables()
        Dim CompanyTableSchema = "create table If not exists company (id int not null auto_increment primary key , name varchar(40) not null, reg_number varchar(25) not null, gst_number varchar(20) not null, addr1 varchar(40) not null, addr2 varchar(40), pin varchar(6) not null)"
        Dim UsersTableSchema = "create table if not exists users (id int not null auto_increment primary key, name varchar(25) not null, username varchar(25) not null, password varchar(20) not null, is_manager bool not null )"
        Dim MedicineTableSchema = "create table if not exists medicines (id int not null auto_increment primary key, name varchar(50) not null, formula varchar(25) not null, company varchar(25), price int, stock int)"
        Dim SalesTableSchema = "create table if not exists sales(id int not null auto_increment primary key,date datetime default now(), amount int not null)"
        Try
            Form1.DbConnection.Open()
            Dim Cmd1 = New MySqlCommand(CompanyTableSchema, Form1.DbConnection)
            Dim cmd2 = New MySqlCommand(UsersTableSchema, Form1.DbConnection)
            Dim Cmd3 = New MySqlCommand(MedicineTableSchema, Form1.DbConnection)
            Dim Cmd4 = New MySqlCommand(SalesTableSchema, Form1.DbConnection)
            Cmd1.ExecuteNonQuery()
            cmd2.ExecuteNonQuery()
            Cmd3.ExecuteNonQuery()
            Cmd4.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Form1.DbConnection.Close()
        End Try
    End Sub
End Module
