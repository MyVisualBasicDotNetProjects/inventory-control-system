﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.312
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System


<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"),  _
 Serializable(),  _
 System.ComponentModel.DesignerCategoryAttribute("code"),  _
 System.ComponentModel.ToolboxItem(true),  _
 System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedDataSetSchema"),  _
 System.Xml.Serialization.XmlRootAttribute("LoginDataSet"),  _
 System.ComponentModel.Design.HelpKeywordAttribute("vs.data.DataSet")>  _
Partial Public Class LoginDataSet
    Inherits System.Data.DataSet
    
    Private tableUsers As UsersDataTable
    
    Private _schemaSerializationMode As System.Data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Sub New()
        MyBase.New
        Me.BeginInit
        Me.InitClass
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler MyBase.Tables.CollectionChanged, schemaChangedHandler
        AddHandler MyBase.Relations.CollectionChanged, schemaChangedHandler
        Me.EndInit
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Sub New(ByVal info As System.Runtime.Serialization.SerializationInfo, ByVal context As System.Runtime.Serialization.StreamingContext)
        MyBase.New(info, context, false)
        If (Me.IsBinarySerialized(info, context) = true) Then
            Me.InitVars(false)
            Dim schemaChangedHandler1 As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
            AddHandler Me.Tables.CollectionChanged, schemaChangedHandler1
            AddHandler Me.Relations.CollectionChanged, schemaChangedHandler1
            Return
        End If
        Dim strSchema As String = CType(info.GetValue("XmlSchema", GetType(String)),String)
        If (Me.DetermineSchemaSerializationMode(info, context) = System.Data.SchemaSerializationMode.IncludeSchema) Then
            Dim ds As System.Data.DataSet = New System.Data.DataSet
            ds.ReadXmlSchema(New System.Xml.XmlTextReader(New System.IO.StringReader(strSchema)))
            If (Not (ds.Tables("Users")) Is Nothing) Then
                MyBase.Tables.Add(New UsersDataTable(ds.Tables("Users")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
            Me.InitVars
        Else
            Me.ReadXmlSchema(New System.Xml.XmlTextReader(New System.IO.StringReader(strSchema)))
        End If
        Me.GetSerializationData(info, context)
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler MyBase.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property Users() As UsersDataTable
        Get
            Return Me.tableUsers
        End Get
    End Property
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.ComponentModel.BrowsableAttribute(true),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Visible)>  _
    Public Overrides Property SchemaSerializationMode() As System.Data.SchemaSerializationMode
        Get
            Return Me._schemaSerializationMode
        End Get
        Set
            Me._schemaSerializationMode = value
        End Set
    End Property
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>  _
    Public Shadows ReadOnly Property Tables() As System.Data.DataTableCollection
        Get
            Return MyBase.Tables
        End Get
    End Property
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>  _
    Public Shadows ReadOnly Property Relations() As System.Data.DataRelationCollection
        Get
            Return MyBase.Relations
        End Get
    End Property
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Overrides Sub InitializeDerivedDataSet()
        Me.BeginInit
        Me.InitClass
        Me.EndInit
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Overrides Function Clone() As System.Data.DataSet
        Dim cln As LoginDataSet = CType(MyBase.Clone,LoginDataSet)
        cln.InitVars
        cln.SchemaSerializationMode = Me.SchemaSerializationMode
        Return cln
    End Function
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Overrides Function ShouldSerializeTables() As Boolean
        Return false
    End Function
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Overrides Function ShouldSerializeRelations() As Boolean
        Return false
    End Function
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Overrides Sub ReadXmlSerializable(ByVal reader As System.Xml.XmlReader)
        If (Me.DetermineSchemaSerializationMode(reader) = System.Data.SchemaSerializationMode.IncludeSchema) Then
            Me.Reset
            Dim ds As System.Data.DataSet = New System.Data.DataSet
            ds.ReadXml(reader)
            If (Not (ds.Tables("Users")) Is Nothing) Then
                MyBase.Tables.Add(New UsersDataTable(ds.Tables("Users")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
            Me.InitVars
        Else
            Me.ReadXml(reader)
            Me.InitVars
        End If
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Overrides Function GetSchemaSerializable() As System.Xml.Schema.XmlSchema
        Dim stream As System.IO.MemoryStream = New System.IO.MemoryStream
        Me.WriteXmlSchema(New System.Xml.XmlTextWriter(stream, Nothing))
        stream.Position = 0
        Return System.Xml.Schema.XmlSchema.Read(New System.Xml.XmlTextReader(stream), Nothing)
    End Function
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Friend Overloads Sub InitVars()
        Me.InitVars(true)
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Friend Overloads Sub InitVars(ByVal initTable As Boolean)
        Me.tableUsers = CType(MyBase.Tables("Users"),UsersDataTable)
        If (initTable = true) Then
            If (Not (Me.tableUsers) Is Nothing) Then
                Me.tableUsers.InitVars
            End If
        End If
    End Sub
    
    <System.Diagnostics.DebuggerNonUserC ~dulla^@204~ ~dulla^@204~ vate Sub InitClass()
        Me.Data~dulla^@204~ ginDataSet"
        Me.Prefix = ""
~dulla^@204~ mespace = "http://tempuri.org/LoginDa~dulla^@204~        Me.EnforceConstraints = true
~dulla^@204~ hemaSerializationMode = System.Data.S~dulla^@204~ ationMode.IncludeSchema
        Me.t~dulla^@204~ ew UsersDataTable
        MyBase.Tab~dulla^@204~ bleUsers)
    End Sub
    
    <Sy~dulla^@204~ ics.DebuggerNonUserCodeAttribute()>  ~dulla^@204~ e Function ShouldSerializeUsers() As ~dulla^@204~     Return false
    End Function
 ~dulla^@204~ tem.Diagnostics.DebuggerNonUserCodeAt~dulla^@204~ 
    Private Sub SchemaChanged(ByVal~dulla^@204~ ject, ByVal e As System.ComponentMode~dulla^@204~ hangeEventArgs)
        If (e.Action~dulla^@204~ ponentModel.CollectionChangeAction.Re~dulla^@204~            Me.InitVars
        End I~dulla^@204~ b
    
    <System.Diagnostics.Debu~dulla^@204~ deAttribute()>  _
    Public Shared ~dulla^@204~ ypedDataSetSchema(ByVal xs As System.~dulla^@204~ lSchemaSet) As System.Xml.Schema.XmlS~dulla^@204~ ype
        Dim ds As LoginDataSet =~dulla^@204~ aSet
        Dim type As System.Xml.~dulla^@204~ emaComplexType = New System.Xml.Schem~dulla^@204~ mplexType
        Dim sequence As Sy~dulla^@204~ ma.XmlSchemaSequence = New System.Xml~dulla^@204~ hemaSequence
        xs.Add(ds.GetSc~dulla^@204~ ble)
        Dim any As System.Xml.S~dulla^@204~ maAny = New System.Xml.Schema.XmlSche~dulla^@204~   any.Namespace = ds.Namespace
     ~dulla^@204~ tems.Add(any)
        type.Particle ~dulla^@204~        Return type
    End Function
    
    <System.CodeDom.Compiler.~dulla^@204~ Attribute("System.Data.Design.TypedDa~dulla^@204~ r", "2.0.0.0"),  _
     System.Seria~dulla^@204~ 
     System.Xml.Serialization.XmlSc~dulla^@204~ ttribute("GetTypedTableSchema")>  _
~dulla^@204~ ublic Class UsersDataTable
        I~dulla^@204~ m.Data.DataTable
        Implements ~dulla^@204~ tions.IEnumerable
        
        ~dulla^@204~ nUserName As System.Data.DataColumn
~dulla^@204~      Private columnPassword As System~dulla^@204~ umn
        
        <System.Diagno~dulla^@204~ rNonUserCodeAttribute()>  _
        ~dulla^@204~ w()
            MyBase.New
        ~dulla^@204~ ame = "Users"
            Me.BeginIn~dulla^@204~    Me.InitClass
            Me.EndIn~dulla^@204~ nd Sub
        
        <System.Dia~dulla^@204~ ggerNonUserCodeAttribute()>  _
     ~dulla^@204~  New(ByVal table As System.Data.DataT~dulla^@204~       MyBase.New
            Me.Tabl~dulla^@204~ .TableName
            If (table.Cas~dulla^@204~  table.DataSet.CaseSensitive) Then
 ~dulla^@204~   Me.CaseSensitive = table.CaseSensit~dulla^@204~     End If
            If (table.Loc~dulla^@204~ <> table.DataSet.Locale.ToString) The~dulla^@204~       Me.Locale = table.Locale
     ~dulla^@204~ 
            If (table.Namespace <> ~dulla^@204~ .Namespace) Then
                Me.~dulla^@204~ able.Namespace
            End If
 ~dulla^@204~ .Prefix = table.Prefix
            M~dulla^@204~ city = table.MinimumCapacity
       ~dulla^@204~      
        <System.Diagnostics.De~dulla^@204~ CodeAttribute()>  _
        Protecte~dulla^@204~ al info As System.Runtime.Serializati~dulla^@204~ ionInfo, ByVal context As System.Runt~dulla^@204~ tion.StreamingContext)
            M~dulla^@204~ o, context)
            Me.InitVars
        
        <System.Diagno~dulla^@204~ rNonUserCodeAttribute()>  _
        ~dulla^@204~ ly Property UserNameColumn() As Syste~dulla^@204~ lumn
            Get
              ~dulla^@204~ olumnUserName
            End Get
 ~dulla^@204~ operty
        
        <System.Dia~dulla^@204~ ggerNonUserCodeAttribute()>  _
     ~dulla^@204~ dOnly Property PasswordColumn() As Sy~dulla^@204~ aColumn
            Get
           ~dulla^@204~ e.columnPassword
            End Get~dulla^@204~  Property
        
        <System.~dulla^@204~ ebuggerNonUserCodeAttribute(),  _
  ~dulla^@204~ .ComponentModel.Browsable(false)>  _
                Return Me.Row~dulla^@204~         End Get
        End Property~dulla^@204~        <System.Diagnostics.DebuggerNo~dulla^@204~ ibute()>  _
        Public Default R~dulla^@204~ rty Item(ByVal index As Integer) As U~dulla^@204~         Get
                Return C~dulla^@204~ index),UsersRow)
            End Get~dulla^@204~  Property
        
        Public E~dulla^@204~ Changing As UsersRowChangeEventHandle~dulla^@204~         Public Event UsersRowChanged ~dulla^@204~ angeEventHandler
        
        P~dulla^@204~ sersRowDeleting As UsersRowChangeEven~dulla^@204~      
        Public Event UsersRowD~dulla^@204~ rsRowChangeEventHandler
        
  ~dulla^@204~ .Diagnostics.DebuggerNonUserCodeAttri~dulla^@204~        Public Overloads Sub AddUsersR~dulla^@204~ As UsersRow)
            Me.Rows.Add~dulla^@204~   End Sub
        
        <System.~dulla^@204~ ebuggerNonUserCodeAttribute()>  _
  ~dulla^@204~ Overloads Function AddUsersRow(ByVal ~dulla^@204~ tring, ByVal Password As String) As U~dulla^@204~         Dim rowUsersRow As UsersRow =~dulla^@204~ Row,UsersRow)
            rowUsersRo~dulla^@204~  New Object() {UserName, Password}
 ~dulla^@204~ .Rows.Add(rowUsersRow)
            R~dulla^@204~ sRow
        End Function
        
        Public Overridable Function~dulla^@204~ r() As System.Collections.IEnumerator~dulla^@204~ ystem.Collections.IEnumerable.GetEnum~dulla^@204~        Return Me.Rows.GetEnumerator
~dulla^@204~ unction
        
        <System.Di~dulla^@204~ uggerNonUserCodeAttribute()>  _
    ~dulla^@204~ errides Function Clone() As System.Da~dulla^@204~ 
            Dim cln As UsersDataTabl~dulla^@204~ ase.Clone,UsersDataTable)
          ~dulla^@204~ s
            Return cln
        En~dulla^@204~        
        <System.Diagnostics.~dulla^@204~ erCodeAttribute()>  _
        Protec~dulla^@204~  Function CreateInstance() As System.~dulla^@204~ e
            Return New UsersDataTa~dulla^@204~ End Function
        
        <Syst~dulla^@204~ s.DebuggerNonUserCodeAttribute()>  _
            Me.col~dulla^@204~  MyBase.Columns("UserName")
        ~dulla^@204~ Password = MyBase.Columns("Password")~dulla^@204~  Sub
        
        <System.Diagn~dulla^@204~ erNonUserCodeAttribute()>  _
       ~dulla^@204~ InitClass()
            Me.columnUse~dulla^@204~ ystem.Data.DataColumn("UserName", Get~dulla^@204~  Nothing, System.Data.MappingType.Ele~dulla^@204~       MyBase.Columns.Add(Me.columnUse~dulla^@204~        Me.columnPassword = New System~dulla^@204~ umn("Password", GetType(String), Noth~dulla^@204~ ata.MappingType.Element)
           ~dulla^@204~ ns.Add(Me.columnPassword)
          ~dulla^@204~ erName.AllowDBNull = false
         ~dulla^@204~ serName.MaxLength = 10
            M~dulla^@204~ ord.AllowDBNull = false
            ~dulla^@204~ word.MaxLength = 6
        End Sub
~dulla^@204~      <System.Diagnostics.DebuggerNonU~dulla^@204~ ute()>  _
        Public Function Ne~dulla^@204~ s UsersRow
            Return CType(~dulla^@204~ rsRow)
        End Function
       ~dulla^@204~ ystem.Diagnostics.DebuggerNonUserCode~dulla^@204~  _
        Protected Overrides Funct~dulla^@204~ mBuilder(ByVal builder As System.Data~dulla^@204~ er) As System.Data.DataRow
         ~dulla^@204~  UsersRow(builder)
        End Funct~dulla^@204~ 
        <System.Diagnostics.Debugge~dulla^@204~ ttribute()>  _
        Protected Ove~dulla^@204~ on GetRowType() As System.Type
     ~dulla^@204~  GetType(UsersRow)
        End Funct~dulla^@204~ 
        <System.Diagnostics.Debugge~dulla^@204~ ttribute()>  _
        Protected Ove~dulla^@204~ RowChanged(ByVal e As System.Data.Dat~dulla^@204~ ntArgs)
            MyBase.OnRowChan~dulla^@204~        If (Not (Me.UsersRowChangedEve~dulla^@204~ g) Then
                RaiseEvent UsersRowChanged(Me, New UsersRowChangeEvent~dulla^@204~ UsersRow), e.Action))
            En~dulla^@204~  End Sub
        
        <System.D~dulla^@204~ buggerNonUserCodeAttribute()>  _
   ~dulla^@204~ d Overrides Sub OnRowChanging(ByVal e~dulla^@204~ ta.DataRowChangeEventArgs)
         ~dulla^@204~ owChanging(e)
            If (Not (M~dulla^@204~ ngingEvent) Is Nothing) Then
       ~dulla^@204~ eEvent UsersRowChanging(Me, New Users~dulla^@204~ t(CType(e.Row,UsersRow), e.Action))
~dulla^@204~ nd If
        End Sub
        
   ~dulla^@204~ Diagnostics.DebuggerNonUserCodeAttrib~dulla^@204~       Protected Overrides Sub OnRowDe~dulla^@204~  As System.Data.DataRowChangeEventArg~dulla^@204~    MyBase.OnRowDeleted(e)
          ~dulla^@204~ .UsersRowDeletedEvent) Is Nothing) Th~dulla^@204~        RaiseEvent UsersRowDeleted(Me,~dulla^@204~ ChangeEvent(CType(e.Row,UsersRow), e.~dulla^@204~          End If
        End Sub
   ~dulla^@204~   <System.Diagnostics.DebuggerNonUser~dulla^@204~ ()>  _
        Protected Overrides S~dulla^@204~ ing(ByVal e As System.Data.DataRowCha~dulla^@204~ 
            MyBase.OnRowDeleting(e)~dulla^@204~  If (Not (Me.UsersRowDeletingEvent) I~dulla^@204~ en
                RaiseEvent UsersR~dulla^@204~ , New UsersRowChangeEvent(CType(e.Row~dulla^@204~ .Action))
            End If
      ~dulla^@204~       
        <System.Diagnostics.D~dulla^@204~ rCodeAttribute()>  _
        Public ~dulla^@204~ rsRow(ByVal row As UsersRow)
       ~dulla^@204~ Remove(row)
        End Sub
       ~dulla^@204~ ystem.Diagnostics.DebuggerNonUserCode~dulla^@204~  _
        Public Shared Function Ge~dulla^@204~ hema(ByVal xs As System.Xml.Schema.Xm~dulla^@204~ s System.Xml.Schema.XmlSchemaComplexT~dulla^@204~     Dim type As System.Xml.Schema.Xml~dulla^@204~ Type = New System.Xml.Schema.XmlSchem~dulla^@204~ 
            Dim sequence As System.X~dulla^@204~ SchemaSequence = New System.Xml.Schem~dulla^@204~ quence
            Dim ds As LoginDa~dulla^@204~ oginDataSet
            xs.Add(ds.Ge~dulla^@204~ izable)
            Dim any1 As Syst~dulla^@204~ .XmlSchemaAny = New System.Xml.Schema~dulla^@204~ 
            any1.Namespace = "http:~dulla^@204~ 2001/XMLSchema"
            any1.Min~dulla^@204~ Decimal(0)
            any1.MaxOccur~dulla^@204~ axValue
            any1.ProcessCont~dulla^@204~ .Xml.Schema.XmlSchemaContentProcessin~dulla^@204~       sequence.Items.Add(any1)
     ~dulla^@204~ y2 As System.Xml.Schema.XmlSchemaAny ~dulla^@204~ Xml.Schema.XmlSchemaAny
            ~dulla^@204~ e = "urn:schemas-microsoft-com:xml-di~dulla^@204~            any2.MinOccurs = New Decim~dulla^@204~       any2.ProcessContents = System.X~dulla^@204~ SchemaContentProcessing.Lax
        ~dulla^@204~ Items.Add(any2)
            Dim attr~dulla^@204~ tem.Xml.Schema.XmlSchemaAttribute = N~dulla^@204~ .Schema.XmlSchemaAttribute
         ~dulla^@204~ .Name = "namespace"
            attr~dulla^@204~ alue = ds.Namespace
            type~dulla^@204~ dd(attribute1)
            Dim attri~dulla^@204~ em.Xml.Schema.XmlSchemaAttribute = Ne~dulla^@204~ Schema.XmlSchemaAttribute
          ~dulla^@204~ Name = "tableTypeName"
            a~dulla^@204~ edValue = "UsersDataTable"
         ~dulla^@204~ butes.Add(attribute2)
            ty~dulla^@204~  sequence
            Return type
 ~dulla^@204~ nction
    End Class
    
    <Sys~dulla^@204~ ompiler.GeneratedCodeAttribute("Syste~dulla^@204~ .TypedDataSetGenerator", "2.0.0.0")> ~dulla^@204~ al Public Class UsersRow
        Inh~dulla^@204~ Data.DataRow
        
        Priva~dulla^@204~  As UsersDataTable
        
       ~dulla^@204~ nostics.DebuggerNonUserCodeAttribute(~dulla^@204~   Friend Sub New(ByVal rb As System.D~dulla^@204~ ilder)
            MyBase.New(rb)
 ~dulla^@204~ .tableUsers = CType(Me.Table,UsersDat~dulla^@204~     End Sub
        
        <Syste~dulla^@204~ .DebuggerNonUserCodeAttribute()>  _
~dulla^@204~ c Property UserName() As String
    ~dulla^@204~                 Return CType(Me(Me.ta~dulla^@204~ NameColumn),String)
            End ~dulla^@204~     Set
                Me(Me.tableU~dulla^@204~ Column) = value
            End Set
        
        <System.D~dulla^@204~ buggerNonUserCodeAttribute()>  _
   ~dulla^@204~ roperty Password() As String
       ~dulla^@204~              Return CType(Me(Me.table~dulla^@204~ dColumn),String)
            End Get~dulla^@204~  Set
                Me(Me.tableUser~dulla^@204~ umn) = value
            End Set
  ~dulla^@204~ perty
    End Class
    
    <Syst~dulla^@204~ mpiler.GeneratedCodeAttribute("System~dulla^@204~ TypedDataSetGenerator", "2.0.0.0")>  ~dulla^@204~  Class UsersRowChangeEvent
        I~dulla^@204~ m.EventArgs
        
        Privat~dulla^@204~  UsersRow
        
        Private ~dulla^@204~ s System.Data.DataRowAction
        ~dulla^@204~ stem.Diagnostics.DebuggerNonUserCodeA~dulla^@204~ _
        Public Sub New(ByVal row A~dulla^@204~ yVal action As System.Data.DataRowAct~dulla^@204~      MyBase.New
            Me.event~dulla^@204~           Me.eventAction = action
  ~dulla^@204~ 
        
        <System.Diagnosti~dulla^@204~ nUserCodeAttribute()>  _
        Pub~dulla^@204~ Property Row() As UsersRow
         ~dulla^@204~            Return Me.eventRow
      ~dulla^@204~ 
        End Property
        
   ~dulla^@204~ Diagnostics.DebuggerNonUserCodeAttrib~dulla^@204~       Public ReadOnly Property Action~dulla^@204~ Data.DataRowAction
            Get
~dulla^@204~    Return Me.eventAction
           ~dulla^@204~      End Property
    End Class
End~dulla^@204~ espace LoginDataSetTableAdapters
   ~dulla^@204~ m.CodeDom.Compiler.GeneratedCodeAttri~dulla^@204~ Data.Design.TypedDataSetGenerator", "~dulla^@204~ 
     System.ComponentModel.Designer~dulla^@204~ bute("code"),  _
     System.Compone~dulla^@204~ oxItem(true),  _
     System.Compone~dulla^@204~ bjectAttribute(true),  _
     System~dulla^@204~ el.DesignerAttribute("Microsoft.VSDes~dulla^@204~ rce.Design.TableAdapterDesigner, Micr~dulla^@204~ ner"& _ 
        ", Version=8.0.0.0,~dulla^@204~ ral, PublicKeyToken=b03f5f7f11d50a3a"~dulla^@204~ ystem.ComponentModel.Design.HelpKeywo~dulla^@204~ vs.data.TableAdapter")>  _
    Parti~dulla^@204~ ss UsersTableAdapter
        Inherit~dulla^@204~ onentModel.Component
        
     ~dulla^@204~ thEvents _adapter As System.Data.SqlC~dulla^@204~ Adapter
        
        Private _c~dulla^@204~ System.Data.SqlClient.SqlConnection
~dulla^@204~      Private _commandCollection() As ~dulla^@204~ qlClient.SqlCommand
        
      ~dulla^@204~ earBeforeFill As Boolean
        
 ~dulla^@204~ m.Diagnostics.DebuggerNonUserCodeAttr~dulla^@204~         Public Sub New()
           ~dulla^@204~             Me.ClearBeforeFill = true~dulla^@204~  Sub
        
        <System.Diagn~dulla^@204~ erNonUserCodeAttribute()>  _
       ~dulla^@204~ Only Property Adapter() As System.Dat~dulla^@204~ qlDataAdapter
            Get
     ~dulla^@204~  (Me._adapter Is Nothing) Then
     ~dulla^@204~   Me.InitAdapter
                End~dulla^@204~         Return Me._adapter
         ~dulla^@204~        End Property
        
      ~dulla^@204~ gnostics.DebuggerNonUserCodeAttribute~dulla^@204~    Friend Property Connection() As Sy~dulla^@204~ Client.SqlConnection
            Get~dulla^@204~      If (Me._connection Is Nothing) T~dulla^@204~             Me.InitConnection
      ~dulla^@204~  If
                Return Me._conne~dulla^@204~       End Get
            Set
     ~dulla^@204~ ._connection = value
               ~dulla^@204~ Adapter.InsertCommand) Is Nothing) Th~dulla^@204~            Me.Adapter.InsertCommand.C~dulla^@204~ alue
                End If
       ~dulla^@204~ Not (Me.Adapter.DeleteCommand) Is Not~dulla^@204~                    Me.Adapter.DeleteC~dulla^@204~ tion = value
                End If
                    Me.Adapter~dulla^@204~ d.Connection = value
               ~dulla^@204~             Dim i As Integer = 0
   ~dulla^@204~ Do While (i < Me.CommandCollection.Length)
                    If (Not (Me.Com~dulla^@204~ n(i)) Is Nothing) Then
             ~dulla^@204~ ype(Me.CommandCollection(i),System.Da~dulla^@204~ SqlCommand).Connection = value
     ~dulla^@204~   End If
                    i = (i ~dulla^@204~          Loop
            End Set
 ~dulla^@204~ operty
        
        <System.Dia~dulla^@204~ ggerNonUserCodeAttribute()>  _
     ~dulla^@204~ ReadOnly Property CommandCollection()~dulla^@204~ ta.SqlClient.SqlCommand()
          ~dulla^@204~           If (Me._commandCollection I~dulla^@204~ en
                    Me.InitComman~dulla^@204~                 End If
             ~dulla^@204~ _commandCollection
            End G~dulla^@204~ nd Property
        
        <Syste~dulla^@204~ .DebuggerNonUserCodeAttribute()>  _
~dulla^@204~ c Property ClearBeforeFill() As Boole~dulla^@204~    Get
                Return Me._cl~dulla^@204~ 
            End Get
            Se~dulla^@204~       Me._clearBeforeFill = value
  ~dulla^@204~  Set
        End Property
        
        Private Sub InitAdapter()
~dulla^@204~ e._adapter = New System.Data.SqlClien~dulla^@204~ ter
            Dim tableMapping As ~dulla^@204~ ommon.DataTableMapping = New System.D~dulla^@204~ taTableMapping
            tableMapp~dulla^@204~ le = "Table"
            tableMappin~dulla^@204~ e = "Users"
            tableMapping~dulla^@204~ gs.Add("UserName", "UserName")
     ~dulla^@204~ apping.ColumnMappings.Add("Password",~dulla^@204~ 
            Me._adapter.TableMapping~dulla^@204~ pping)
            Me._adapter.Inser~dulla^@204~ w System.Data.SqlClient.SqlCommand
 ~dulla^@204~ ._adapter.InsertCommand.Connection = ~dulla^@204~ 
            Me._adapter.InsertComma~dulla^@204~ t = "INSERT INTO [dbo].[Users] ([User~dulla^@204~ ord]) VALUES (@UserName, @Password)"
            Me._a~dulla^@204~ Command.Parameters.Add(New System.Dat~dulla^@204~ qlParameter("@UserName", System.Data.~dulla^@204~ ar], 0, System.Data.ParameterDirectio~dulla^@204~ , "UserName", System.Data.DataRowVers~dulla^@204~ false, Nothing, "", "", ""))
       ~dulla^@204~ ter.InsertCommand.Parameters.Add(New ~dulla^@204~ qlClient.SqlParameter("@Password", Sy~dulla^@204~ DbType.[Char], 0, System.Data.Paramet~dulla^@204~ nput, 0, 0, "Password", System.Data.D~dulla^@204~ .Current, false, Nothing, "", "", "")~dulla^@204~ d Sub
        
        <System.Diag~dulla^@204~ gerNonUserCodeAttribute()>  _
      ~dulla^@204~  InitConnection()
            Me._co~dulla^@204~ w System.Data.SqlClient.SqlConnection~dulla^@204~  Me._connection.ConnectionString = Gl~dulla^@204~ yControlSystem.My.MySettings.Default.~dulla^@204~ onnection
        End Sub
        
        Private Sub InitCommandColl~dulla^@204~          Me._commandCollection = New ~dulla^@204~ qlClient.SqlCommand(0) {}
          ~dulla^@204~ Collection(0) = New System.Data.SqlCl~dulla^@204~ nd
            Me._commandCollection~dulla^@204~ n = Me.Connection
            Me._co~dulla^@204~ on(0).CommandText = "SELECT UserName,~dulla^@204~ M dbo.Users"
            Me._command~dulla^@204~ .CommandType = System.Data.CommandTyp~dulla^@204~    End Sub
        
        <System~dulla^@204~ DebuggerNonUserCodeAttribute(),  _
 ~dulla^@204~ m.ComponentModel.Design.HelpKeywordAt~dulla^@204~ ata.TableAdapter"),  _
         Syst~dulla^@204~ odel.DataObjectMethodAttribute(System~dulla^@204~ el.DataObjectMethodType.Fill, true)> ~dulla^@204~ ublic Overloads Overridable Function ~dulla^@204~ taTable As LoginDataSet.UsersDataTabl~dulla^@204~ 
            Me.Adapter.SelectComman~dulla^@204~ dCollection(0)
            If (Me.Cl~dulla^@204~  = true) Then
                dataTa~dulla^@204~           End If
            Dim ret~dulla^@204~ nteger = Me.Adapter.Fill(dataTable)
~dulla^@204~ eturn returnValue
        End Functi~dulla^@204~ 
        <System.Diagnostics.Debugger~dulla^@204~ tribute(),  _
         System.Compon~dulla^@204~ gn.HelpKeywordAttribute("vs.data.Tabl~dulla^@204~ _
         System.ComponentModel.Dat~dulla^@204~ Attribute(System.ComponentModel.DataO~dulla^@204~ pe.[Select], true)>  _
        Publi~dulla^@204~ verridable Function GetData() As Logi~dulla^@204~ sDataTable
            Me.Adapter.Se~dulla^@204~  Me.CommandCollection(0)
           ~dulla^@204~ e As LoginDataSet.UsersDataTable = Ne~dulla^@204~ t.UsersDataTable
            Me.Adap~dulla^@204~ Table)
            Return dataTable
        
        <System.D~dulla^@204~ buggerNonUserCodeAttribute(),  _
   ~dulla^@204~ ComponentModel.Design.HelpKeywordAttr~dulla^@204~ a.TableAdapter")>  _
        Public ~dulla^@204~ rridable Function Update(ByVal dataTa~dulla^@204~ ataSet.UsersDataTable) As Integer
  ~dulla^@204~ urn Me.Adapter.Update(dataTable)
   ~dulla^@204~ tion
        
        <System.Diagn~dulla^@204~ erNonUserCodeAttribute(),  _
       ~dulla^@204~ onentModel.Design.HelpKeywordAttribut~dulla^@204~ bleAdapter")>  _
        Public Over~dulla^@204~ able Function Update(ByVal dataSet As~dulla^@204~ ) As Integer
            Return Me.A~dulla^@204~ (dataSet, "Users")
        End Funct~dulla^@204~ 
        <System.Diagnostics.Debugge~dulla^@204~ ttribute(),  _
         System.Compo~dulla^@204~ ign.HelpKeywordAttribute("vs.data.Tab~dulla^@204~  _
        Public Overloads Overrida~dulla^@204~ Update(ByVal dataRow As System.Data.D~dulla^@204~ teger
            Return Me.Adapter.~dulla^@204~ stem.Data.DataRow() {dataRow})
     ~dulla^@204~ on
        
        <System.Diagnos~dulla^@204~ NonUserCodeAttribute(),  _
         ~dulla^@204~ entModel.Design.HelpKeywordAttribute(~dulla^@204~ eAdapter")>  _
        Public Overlo~dulla^@204~ le Function Update(ByVal dataRows() A~dulla^@204~ .DataRow) As Integer
            Ret~dulla^@204~ r.Update(dataRows)
        End Funct~dulla^@204~ 
        <System.Diagnostics.Debugge~dulla^@204~ ttribute(),  _
         System.Compo~dulla^@204~ ign.HelpKeywordAttribute("vs.data.Tab~dulla^@204~  _
         System.ComponentModel.Da~dulla^@204~ dAttribute(System.ComponentModel.Data~dulla^@204~ ype.Insert, true)>  _
        Public~dulla^@204~ erridable Function Insert(ByVal UserN~dulla^@204~ , ByVal Password As String) As Intege~dulla^@204~   If (UserName Is Nothing) Then
    ~dulla^@204~ hrow New System.ArgumentNullException~dulla^@204~ 
            Else
                Me~dulla^@204~ rtCommand.Parameters(0).Value = CType~dulla^@204~ ing)
            End If
           ~dulla^@204~  Is Nothing) Then
                Th~dulla^@204~ m.ArgumentNullException("Password")
~dulla^@204~ lse
                Me.Adapter.Inser~dulla^@204~ meters(1).Value = CType(Password,Stri~dulla^@204~     End If
            Dim previousC~dulla^@204~ e As System.Data.ConnectionState = Me~dulla^@204~ rtCommand.Connection.State
         ~dulla^@204~ apter.InsertCommand.Connection.State ~dulla^@204~ ta.ConnectionState.Open)  _
        ~dulla^@204~    <> System.Data.ConnectionState.Ope~dulla^@204~             Me.Adapter.InsertCommand.~dulla^@204~ en
            End If
            T~dulla^@204~         Dim returnValue As Integer = ~dulla^@204~ sertCommand.ExecuteNonQuery
        ~dulla^@204~ n returnValue
            Finally
 ~dulla^@204~   If (previousConnectionState = Syste~dulla^@204~ tionState.Closed) Then
             ~dulla^@204~ pter.InsertCommand.Connection.Close
~dulla^@204~    End If
            End Try
        End Function
    End Class
End Namespace