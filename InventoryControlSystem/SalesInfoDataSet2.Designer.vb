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
 System.Xml.Serialization.XmlRootAttribute("SalesInfoDataSet2"),  _
 System.ComponentModel.Design.HelpKeywordAttribute("vs.data.DataSet")>  _
Partial Public Class SalesInfoDataSet2
    Inherits System.Data.DataSet
    
    Private tableSalesInfo As SalesInfoDataTable
    
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
            If (Not (ds.Tables("SalesInfo")) Is Nothing) Then
                MyBase.Tables.Add(New SalesInfoDataTable(ds.Tables("SalesInfo")))
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
    Public ReadOnly Property SalesInfo() As SalesInfoDataTable
        Get
            Return Me.tableSalesInfo
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
        Dim cln As SalesInfoDataSet2 = CType(MyBase.Clone,SalesInfoDataSet2)
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
            If (Not (ds.Tables("SalesInfo")) Is Nothing) Then
                MyBase.Tables.Add(New SalesInfoDataTable(ds.Tables("SalesInfo")))
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
        Me.tableSalesInfo = CType(MyBase.Tables("SalesInfo"),SalesInfoDataTable)
        If (initTable = true) Then
            If (Not (Me.tableSalesInfo) Is Nothing) Then
                Me.tableSalesInfo.InitVars
            ~dulla^@204~ ~dulla^@204~   End Sub
    
    <System.Diagnost~dulla^@204~ onUserCodeAttribute()>  _
    Privat~dulla^@204~ ss()
        Me.DataSetName = "Sales~dulla^@204~ 
        Me.Prefix = ""
        Me.~dulla^@204~ http://tempuri.org/SalesInfoDataSet2.~dulla^@204~  Me.EnforceConstraints = true
      ~dulla^@204~ rializationMode = System.Data.SchemaS~dulla^@204~ ode.IncludeSchema
        Me.tableSa~dulla^@204~  SalesInfoDataTable
        MyBase.T~dulla^@204~ tableSalesInfo)
    End Sub
    
 ~dulla^@204~ agnostics.DebuggerNonUserCodeAttribut~dulla^@204~ Private Function ShouldSerializeSales~dulla^@204~ lean
        Return false
    End F~dulla^@204~ 
    <System.Diagnostics.DebuggerNon~dulla^@204~ bute()>  _
    Private Sub SchemaCha~dulla^@204~ nder As Object, ByVal e As System.Com~dulla^@204~ ollectionChangeEventArgs)
        If~dulla^@204~ System.ComponentModel.CollectionChang~dulla^@204~ e) Then
            Me.InitVars
   ~dulla^@204~     End Sub
    
    <System.Diagno~dulla^@204~ rNonUserCodeAttribute()>  _
    Publ~dulla^@204~ ction GetTypedDataSetSchema(ByVal xs ~dulla^@204~ .Schema.XmlSchemaSet) As System.Xml.S~dulla^@204~ maComplexType
        Dim ds As Sale~dulla^@204~  = New SalesInfoDataSet2
        Dim~dulla^@204~ em.Xml.Schema.XmlSchemaComplexType = ~dulla^@204~ l.Schema.XmlSchemaComplexType
      ~dulla^@204~ e As System.Xml.Schema.XmlSchemaSeque~dulla^@204~ tem.Xml.Schema.XmlSchemaSequence
   ~dulla^@204~ s.GetSchemaSerializable)
        Dim~dulla^@204~ m.Xml.Schema.XmlSchemaAny = New Syste~dulla^@204~ XmlSchemaAny
        any.Namespace =~dulla^@204~ 
        sequence.Items.Add(any)
  ~dulla^@204~ rticle = sequence
        Return typ~dulla^@204~ nction
    
    Public Delegate Sub~dulla^@204~ ChangeEventHandler(ByVal sender As Ob~dulla^@204~  As SalesInfoRowChangeEvent)
    
 ~dulla^@204~ deDom.Compiler.GeneratedCodeAttribute~dulla^@204~ .Design.TypedDataSetGenerator", "2.0.~dulla^@204~    System.Serializable(),  _
     Sy~dulla^@204~ alization.XmlSchemaProviderAttribute(~dulla^@204~ eSchema")>  _
    Partial Public Cla~dulla^@204~ ataTable
        Inherits System.Dat~dulla^@204~         Implements System.Collections~dulla^@204~ 
        
        Private columnPart~dulla^@204~ Data.DataColumn
        
        Pr~dulla^@204~ escription As System.Data.DataColumn~dulla^@204~       Private columnQuantity As Syste~dulla^@204~ lumn
        
        Private colum~dulla^@204~  System.Data.DataColumn
        
  ~dulla^@204~  columnAmount As System.Data.DataColu~dulla^@204~ 
        <System.Diagnostics.Debugger~dulla^@204~ tribute()>  _
        Public Sub New~dulla^@204~    MyBase.New
            Me.TableNa~dulla^@204~ fo"
            Me.BeginInit
      ~dulla^@204~ Class
            Me.EndInit
      ~dulla^@204~       
        <System.Diagnostics.D~dulla^@204~ rCodeAttribute()>  _
        Friend ~dulla^@204~  table As System.Data.DataTable)
   ~dulla^@204~ se.New
            Me.TableName = ta~dulla^@204~ 
            If (table.CaseSensitive~dulla^@204~ aSet.CaseSensitive) Then
           ~dulla^@204~ ensitive = table.CaseSensitive
     ~dulla^@204~ 
            If (table.Locale.ToStri~dulla^@204~ ataSet.Locale.ToString) Then
       ~dulla^@204~ ocale = table.Locale
            End~dulla^@204~     If (table.Namespace <> table.Data~dulla^@204~ ) Then
                Me.Namespace ~dulla^@204~ pace
            End If
           ~dulla^@204~ table.Prefix
            Me.MinimumC~dulla^@204~ le.MinimumCapacity
        End Sub
~dulla^@204~      <System.Diagnostics.DebuggerNonU~dulla^@204~ ute()>  _
        Protected Sub New(~dulla^@204~  System.Runtime.Serialization.Seriali~dulla^@204~ yVal context As System.Runtime.Serial~dulla^@204~ mingContext)
            MyBase.New(~dulla^@204~ )
            Me.InitVars
        E~dulla^@204~    
        <System.Diagnostics.Debu~dulla^@204~ deAttribute()>  _
        Public Rea~dulla^@204~ y PartNoColumn() As System.Data.DataC~dulla^@204~       Get
                Return Me.~dulla^@204~ 
            End Get
        End Pro~dulla^@204~   
        <System.Diagnostics.Debug~dulla^@204~ eAttribute()>  _
        Public Read~dulla^@204~  DescriptionColumn() As System.Data.D~dulla^@204~           Get
                Return~dulla^@204~ cription
            End Get
      ~dulla^@204~ y
        
        <System.Diagnost~dulla^@204~ onUserCodeAttribute()>  _
        Pu~dulla^@204~  Property QuantityColumn() As System.~dulla^@204~ mn
            Get
                ~dulla^@204~ umnQuantity
            End Get
   ~dulla^@204~ erty
        
        <System.Diagn~dulla^@204~ erNonUserCodeAttribute()>  _
       ~dulla^@204~ nly Property UnitPriceColumn() As Sys~dulla^@204~ Column
            Get
            ~dulla^@204~ .columnUnitPrice
            End Get~dulla^@204~  Property
        
        <System.~dulla^@204~ ebuggerNonUserCodeAttribute()>  _
  ~dulla^@204~ ReadOnly Property AmountColumn() As S~dulla^@204~ taColumn
            Get
          ~dulla^@204~ Me.columnAmount
            End Get~dulla^@204~ Property
        
        <System.D~dulla^@204~ buggerNonUserCodeAttribute(),  _
   ~dulla^@204~ ComponentModel.Browsable(false)>  _
~dulla^@204~ c ReadOnly Property Count() As Intege~dulla^@204~   Get
                Return Me.Rows~dulla^@204~        End Get
        End Property~dulla^@204~       <System.Diagnostics.DebuggerNon~dulla^@204~ bute()>  _
        Public Default Re~dulla^@204~ ty Item(ByVal index As Integer) As Sa~dulla^@204~            Get
                Retur~dulla^@204~ ws(index),SalesInfoRow)
            ~dulla^@204~     End Property
        
        P~dulla^@204~ alesInfoRowChanging As SalesInfoRowCh~dulla^@204~ ler
        
        Public Event S~dulla^@204~ anged As SalesInfoRowChangeEventHandl~dulla^@204~ 
        Public Event SalesInfoRowDel~dulla^@204~ sInfoRowChangeEventHandler
        ~dulla^@204~ ic Event SalesInfoRowDeleted As Sales~dulla^@204~ EventHandler
        
        <Syst~dulla^@204~ s.DebuggerNonUserCodeAttribute()>  _~dulla^@204~ ic Overloads Sub AddSalesInfoRow(ByVa~dulla^@204~ sInfoRow)
            Me.Rows.Add(ro~dulla^@204~ nd Sub
        
        <System.Dia~dulla^@204~ ggerNonUserCodeAttribute()>  _
     ~dulla^@204~ rloads Function AddSalesInfoRow(ByVal~dulla^@204~ ring, ByVal Description As String, By~dulla^@204~ As Integer, ByVal UnitPrice As Decima~dulla^@204~ nt As Decimal) As SalesInfoRow
     ~dulla^@204~ wSalesInfoRow As SalesInfoRow = CType~dulla^@204~ lesInfoRow)
            rowSalesInfo~dulla^@204~  = New Object() {PartNo, Description,~dulla^@204~ itPrice, Amount}
            Me.Rows~dulla^@204~ InfoRow)
            Return rowSales~dulla^@204~     End Function
        
        <~dulla^@204~ stics.DebuggerNonUserCodeAttribute()>~dulla^@204~ Public Overridable Function GetEnumer~dulla^@204~ tem.Collections.IEnumerator Implement~dulla^@204~ ections.IEnumerable.GetEnumerator
  ~dulla^@204~ urn Me.Rows.GetEnumerator
        En~dulla^@204~        
        <System.Diagnostics.~dulla^@204~ erCodeAttribute()>  _
        Public~dulla^@204~ nction Clone() As System.Data.DataTab~dulla^@204~    Dim cln As SalesInfoDataTable = CT~dulla^@204~ one,SalesInfoDataTable)
            ~dulla^@204~ 
            Return cln
        End ~dulla^@204~      
        <System.Diagnostics.De~dulla^@204~ CodeAttribute()>  _
        Protecte~dulla^@204~ unction CreateInstance() As System.Da~dulla^@204~ 
            Return New SalesInfoData~dulla^@204~   End Function
        
        <Sy~dulla^@204~ ics.DebuggerNonUserCodeAttribute()>  ~dulla^@204~ iend Sub InitVars()
            Me.c~dulla^@204~  MyBase.Columns("PartNo")
          ~dulla^@204~ scription = MyBase.Columns("Descripti~dulla^@204~      Me.columnQuantity = MyBase.Colum~dulla^@204~ )
            Me.columnUnitPrice = M~dulla^@204~ ("UnitPrice")
            Me.columnA~dulla^@204~ e.Columns("Amount")
        End Sub~dulla^@204~       <System.Diagnostics.DebuggerNon~dulla^@204~ bute()>  _
        Private Sub InitC~dulla^@204~        Me.columnPartNo = New System.Data.DataColumn("PartNo", GetType(String), ~dulla^@204~ em.Data.MappingType.Element)
       ~dulla^@204~ olumns.Add(Me.columnPartNo)
        ~dulla^@204~ Description = New System.Data.DataCol~dulla^@204~ ion", GetType(String), Nothing, Syste~dulla^@204~ gType.Element)
            MyBase.Co~dulla^@204~ columnDescription)
            Me.co~dulla^@204~ = New System.Data.DataColumn("Quantit~dulla^@204~ nteger), Nothing, System.Data.Mapping~dulla^@204~ 
            MyBase.Columns.Add(Me.c~dulla^@204~ )
            Me.columnUnitPrice = N~dulla^@204~ a.DataColumn("UnitPrice", GetType(Dec~dulla^@204~ g, System.Data.MappingType.Element)
~dulla^@204~ yBase.Columns.Add(Me.columnUnitPrice)~dulla^@204~  Me.columnAmount = New System.Data.Da~dulla^@204~ unt", GetType(Decimal), Nothing, Syst~dulla^@204~ ngType.Element)
            MyBase.C~dulla^@204~ .columnAmount)
            Me.column~dulla^@204~ BNull = false
            Me.columnP~dulla^@204~ th = 20
            Me.columnDescrip~dulla^@204~ h = 20
        End Sub
        
  ~dulla^@204~ .Diagnostics.DebuggerNonUserCodeAttri~dulla^@204~        Public Function NewSalesInfoRo~dulla^@204~ nfoRow
            Return CType(Me.N~dulla^@204~ foRow)
        End Function
       ~dulla^@204~ ystem.Diagnostics.DebuggerNonUserCode~dulla^@204~  _
        Protected Overrides Funct~dulla^@204~ mBuilder(ByVal builder As System.Data~dulla^@204~ er) As System.Data.DataRow
         ~dulla^@204~  SalesInfoRow(builder)
        End F~dulla^@204~     
        <System.Diagnostics.Deb~dulla^@204~ odeAttribute()>  _
        Protected~dulla^@204~ nction GetRowType() As System.Type
 ~dulla^@204~ turn GetType(SalesInfoRow)
        E~dulla^@204~         
        <System.Diagnostics~dulla^@204~ serCodeAttribute()>  _
        Prote~dulla^@204~ s Sub OnRowChanged(ByVal e As System.~dulla^@204~ hangeEventArgs)
            MyBase.O~dulla^@204~ )
            If (Not (Me.SalesInfoR~dulla^@204~ t) Is Nothing) Then
                ~dulla^@204~ lesInfoRowChanged(Me, New SalesInfoRo~dulla^@204~ CType(e.Row,SalesInfoRow), e.Action))~dulla^@204~  End If
        End Sub
        
 ~dulla^@204~ m.Diagnostics.DebuggerNonUserCodeAttr~dulla^@204~         Protected Overrides Sub OnRow~dulla^@204~ l e As System.Data.DataRowChangeEvent~dulla^@204~       MyBase.OnRowChanging(e)
      ~dulla^@204~  (Me.SalesInfoRowChangingEvent) Is No~dulla^@204~                 RaiseEvent SalesInfoR~dulla^@204~ , New SalesInfoRowChangeEvent(CType(e~dulla^@204~ oRow), e.Action))
            End If~dulla^@204~  Sub
        
        <System.Diagn~dulla^@204~ erNonUserCodeAttribute()>  _
       ~dulla^@204~ errides Sub OnRowDeleted(ByVal e As S~dulla^@204~ taRowChangeEventArgs)
            My~dulla^@204~ eted(e)
            If (Not (Me.Sale~dulla^@204~ edEvent) Is Nothing) Then
          ~dulla^@204~ ent SalesInfoRowDeleted(Me, New Sales~dulla^@204~ Event(CType(e.Row,SalesInfoRow), e.Ac~dulla^@204~        End If
        End Sub
     ~dulla^@204~ <System.Diagnostics.DebuggerNonUserCo~dulla^@204~ >  _
        Protected Overrides Sub~dulla^@204~ g(ByVal e As System.Data.DataRowChang~dulla^@204~             MyBase.OnRowDeleting(e)
~dulla^@204~ f (Not (Me.SalesInfoRowDeletingEvent)~dulla^@204~ Then
                RaiseEvent Sale~dulla^@204~ ing(Me, New SalesInfoRowChangeEvent(C~dulla^@204~ lesInfoRow), e.Action))
            ~dulla^@204~    End Sub
        
        <System~dulla^@204~ DebuggerNonUserCodeAttribute()>  _
 ~dulla^@204~  Sub RemoveSalesInfoRow(ByVal row As ~dulla^@204~ 
            Me.Rows.Remove(row)
  ~dulla^@204~ 
        
        <System.Diagnosti~dulla^@204~ nUserCodeAttribute()>  _
        Pub~dulla^@204~ nction GetTypedTableSchema(ByVal xs A~dulla^@204~ Schema.XmlSchemaSet) As System.Xml.Sc~dulla^@204~ aComplexType
            Dim type As~dulla^@204~ chema.XmlSchemaComplexType = New Syst~dulla^@204~ .XmlSchemaComplexType
            Di~dulla^@204~  System.Xml.Schema.XmlSchemaSequence ~dulla^@204~ Xml.Schema.XmlSchemaSequence
       ~dulla^@204~ s SalesInfoDataSet2 = New SalesInfoDa~dulla^@204~        xs.Add(ds.GetSchemaSerializabl~dulla^@204~    Dim any1 As System.Xml.Schema.XmlS~dulla^@204~ w System.Xml.Schema.XmlSchemaAny
   ~dulla^@204~ .Namespace = "http://www.w3.org/2001/~dulla^@204~            any1.MinOccurs = New Decim~dulla^@204~       any1.MaxOccurs = Decimal.MaxVal~dulla^@204~    any1.ProcessContents = System.Xml.~dulla^@204~ emaContentProcessing.Lax
           ~dulla^@204~ ms.Add(any1)
            Dim any2 As~dulla^@204~ chema.XmlSchemaAny = New System.Xml.S~dulla^@204~ maAny
            any2.Namespace = "~dulla^@204~ icrosoft-com:xml-diffgram-v1"
      ~dulla^@204~ nOccurs = New Decimal(1)
           ~dulla^@204~ Contents = System.Xml.Schema.XmlSchem~dulla^@204~ ssing.Lax
            sequence.Items~dulla^@204~            Dim attribute1 As System.X~dulla^@204~ SchemaAttribute = New System.Xml.Sche~dulla^@204~ ttribute
            attribute1.Name~dulla^@204~ "
            attribute1.FixedValue ~dulla^@204~ e
            type.Attributes.Add(at~dulla^@204~           Dim attribute2 As System.Xm~dulla^@204~ chemaAttribute = New System.Xml.Schem~dulla^@204~ tribute
            attribute2.Name ~dulla^@204~ ame"
            attribute2.FixedVal~dulla^@204~ foDataTable"
            type.Attrib~dulla^@204~ ibute2)
            type.Particle = ~dulla^@204~          Return type
        End Fun~dulla^@204~ d Class
    
    <System.CodeDom.Co~dulla^@204~ tedCodeAttribute("System.Data.Design.~dulla^@204~ enerator", "2.0.0.0")>  _
    Partia~dulla^@204~ s SalesInfoRow
        Inherits Syst~dulla^@204~ ow
        
        Private tableSa~dulla^@204~ lesInfoDataTable
        
        <~dulla^@204~ stics.DebuggerNonUserCodeAttribute()>~dulla^@204~ Friend Sub New(ByVal rb As System.Dat~dulla^@204~ der)
            MyBase.New(rb)
   ~dulla^@204~ ableSalesInfo = CType(Me.Table,SalesI~dulla^@204~ 
        End Sub
        
        ~dulla^@204~ ostics.DebuggerNonUserCodeAttribute()~dulla^@204~  Public Property PartNo() As String
~dulla^@204~ et
                Return CType(Me(M~dulla^@204~ nfo.PartNoColumn),String)
          ~dulla^@204~           Set
                Me(Me.~dulla^@204~ o.PartNoColumn) = value
            ~dulla^@204~     End Property
        
        <~dulla^@204~ stics.DebuggerNonUserCodeAttribute()>~dulla^@204~ Public Property Description() As Stri~dulla^@204~    Get
                Try 
       ~dulla^@204~ Return CType(Me(Me.tableSalesInfo.Des~dulla^@204~ n),String)
                Catch e A~dulla^@204~ lidCastException
                   ~dulla^@204~ stem.Data.StrongTypingException("The ~dulla^@204~ umn 'Description' in table 'SalesInfo~dulla^@204~ , e)
                End Try
      ~dulla^@204~ 
            Set
                Me~dulla^@204~ sInfo.DescriptionColumn) = value
   ~dulla^@204~ Set
        End Property
        
~dulla^@204~ em.Diagnostics.DebuggerNonUserCodeAtt~dulla^@204~ 
        Public Property Quantity() A~dulla^@204~           Get
                Try 
~dulla^@204~        Return CType(Me(Me.tableSalesI~dulla^@204~ olumn),Integer)
                Catc~dulla^@204~ .InvalidCastException
              ~dulla^@204~ ew System.Data.StrongTypingException(~dulla^@204~ r column 'Quantity' in table 'SalesIn~dulla^@204~ .", e)
                End Try
    ~dulla^@204~ et
            Set
                ~dulla^@204~ lesInfo.QuantityColumn) = value
    ~dulla^@204~ et
        End Property
        
 ~dulla^@204~ m.Diagnostics.DebuggerNonUserCodeAttr~dulla^@204~         Public Property UnitPrice() A~dulla^@204~           Get
                Try 
~dulla^@204~        Return CType(Me(Me.tableSalesI~dulla^@204~ Column),Decimal)
                Cat~dulla^@204~ m.InvalidCastException
             ~dulla^@204~ New System.Data.StrongTypingException~dulla^@204~ or column 'UnitPrice' in table 'Sales~dulla^@204~ ll.", e)
                End Try
  ~dulla^@204~  Get
            Set
              ~dulla^@204~ SalesInfo.UnitPriceColumn) = value
 ~dulla^@204~ d Set
        End Property
        ~dulla^@204~ stem.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property Am~dulla^@204~ imal
            Get
              ~dulla^@204~                Return CType(Me(Me.tab~dulla^@204~ mountColumn),Decimal)
              ~dulla^@204~ System.InvalidCastException
        ~dulla^@204~ hrow New System.Data.StrongTypingExce~dulla^@204~ lue for column 'Amount' in table 'Sal~dulla^@204~ Null.", e)
                End Try
~dulla^@204~ nd Get
            Set
            ~dulla^@204~ leSalesInfo.AmountColumn) = value
  ~dulla^@204~  Set
        End Property
        ~dulla^@204~ tem.Diagnostics.DebuggerNonUserCodeAt~dulla^@204~ 
        Public Function IsDescripti~dulla^@204~ oolean
            Return Me.IsNull(~dulla^@204~ Info.DescriptionColumn)
        End ~dulla^@204~      
        <System.Diagnostics.De~dulla^@204~ CodeAttribute()>  _
        Public S~dulla^@204~ tionNull()
            Me(Me.tableSa~dulla^@204~ iptionColumn) = System.Convert.DBNull~dulla^@204~  Sub
        
        <System.Diagn~dulla^@204~ erNonUserCodeAttribute()>  _
       ~dulla^@204~ ion IsQuantityNull() As Boolean
    ~dulla^@204~ n Me.IsNull(Me.tableSalesInfo.Quantit~dulla^@204~      End Function
        
        ~dulla^@204~ ostics.DebuggerNonUserCodeAttribute()~dulla^@204~  Public Sub SetQuantityNull()
      ~dulla^@204~ ableSalesInfo.QuantityColumn) = Syste~dulla^@204~ ull
        End Sub
        
     ~dulla^@204~ agnostics.DebuggerNonUserCodeAttribut~dulla^@204~     Public Function IsUnitPriceNull()~dulla^@204~             Return Me.IsNull(Me.table~dulla^@204~ tPriceColumn)
        End Function
~dulla^@204~      <System.Diagnostics.DebuggerNonU~dulla^@204~ ute()>  _
        Public Sub SetUnit~dulla^@204~             Me(Me.tableSalesInfo.Unit~dulla^@204~ = System.Convert.DBNull
        End ~dulla^@204~ 
        <System.Diagnostics.Debugge~dulla^@204~ ttribute()>  _
        Public Functi~dulla^@204~ ll() As Boolean
            Return M~dulla^@204~ ableSalesInfo.AmountColumn)
        ~dulla^@204~ 
        
        <System.Diagnostic~dulla^@204~ UserCodeAttribute()>  _
        Publ~dulla^@204~ untNull()
            Me(Me.tableSal~dulla^@204~ Column) = System.Convert.DBNull
    ~dulla^@204~     End Class
    
    <System.Code~dulla^@204~ GeneratedCodeAttribute("System.Data.D~dulla^@204~ taSetGenerator", "2.0.0.0")>  _
    ~dulla^@204~ SalesInfoRowChangeEvent
        Inhe~dulla^@204~ ventArgs
        
        Private e~dulla^@204~ lesInfoRow
        
        Private~dulla^@204~ As System.Data.DataRowAction
       ~dulla^@204~ ystem.Diagnostics.DebuggerNonUserCode~dulla^@204~  _
        Public Sub New(ByVal row ~dulla^@204~ ow, ByVal action As System.Data.DataR~dulla^@204~           MyBase.New
            Me.~dulla^@204~ w
            Me.eventAction = actio~dulla^@204~ d Sub
        
        <System.Diag~dulla^@204~ gerNonUserCodeAttribute()>  _
      ~dulla^@204~ Only Property Row() As SalesInfoRow
~dulla^@204~ et
                Return Me.eventRo~dulla^@204~   End Get
        End Property
    ~dulla^@204~  <System.Diagnostics.DebuggerNonUserC~dulla^@204~ )>  _
        Public ReadOnly Proper~dulla^@204~ s System.Data.DataRowAction
        ~dulla^@204~             Return Me.eventAction
  ~dulla^@204~  Get
        End Property
    End C~dulla^@204~ ss

Namespace SalesInfoDataSet2Tabl~dulla^@204~   
    <System.CodeDom.Compiler.Gene~dulla^@204~ ibute("System.Data.Design.TypedDataSe~dulla^@204~ "2.0.0.0"),  _
     System.Component~dulla^@204~ rCategoryAttribute("code"),  _
     ~dulla^@204~ entModel.ToolboxItem(true),  _
     ~dulla^@204~ entModel.DataObjectAttribute(true),  ~dulla^@204~ m.ComponentModel.DesignerAttribute("M~dulla^@204~ signer.DataSource.Design.TableAdapter~dulla^@204~ rosoft.VSDesigner"& _ 
        ", Ve~dulla^@204~ , Culture=neutral, PublicKeyToken=b03~dulla^@204~ "),  _
     System.ComponentModel.De~dulla^@204~ ordAttribute("vs.data.TableAdapter")>~dulla^@204~ ial Public Class SalesInfoTableAdapte~dulla^@204~ herits System.ComponentModel.Componen~dulla^@204~         Private WithEvents _adapter A~dulla^@204~ .SqlClient.SqlDataAdapter
        
~dulla^@204~ te _connection As System.Data.SqlClie~dulla^@204~ ion
        
        Private _comma~dulla^@204~ ) As System.Data.SqlClient.SqlCommand~dulla^@204~        Private _clearBeforeFill As Bo~dulla^@204~   
        <System.Diagnostics.Debug~dulla^@204~ eAttribute()>  _
        Public Sub ~dulla^@204~       MyBase.New
            Me.Clea~dulla^@204~  true
        End Sub
        
   ~dulla^@204~ Diagnostics.DebuggerNonUserCodeAttrib~dulla^@204~       Private ReadOnly Property Adapt~dulla^@204~ m.Data.SqlClient.SqlDataAdapter
    ~dulla^@204~                 If (Me._adapter Is No~dulla^@204~                     Me.InitAdapter
 ~dulla^@204~   End If
                Return Me._~dulla^@204~         End Get
        End Property~dulla^@204~        <System.Diagnostics.DebuggerNo~dulla^@204~ ibute()>  _
        Friend Property ~dulla^@204~ As System.Data.SqlClient.SqlConnectio~dulla^@204~   Get
                If (Me._connec~dulla^@204~ ng) Then
                    Me.Init~dulla^@204~                End If
              ~dulla^@204~ connection
            End Get
    ~dulla^@204~                 Me._connection = valu~dulla^@204~       If (Not (Me.Adapter.InsertComma~dulla^@204~ g) Then
                    Me.Adapt~dulla^@204~ and.Connection = value
             ~dulla^@204~               If (Not (Me.Adapter.Del~dulla^@204~ s Nothing) Then
                    ~dulla^@204~ leteCommand.Connection = value
     ~dulla^@204~ d If
                If (Not (Me.Ada~dulla^@204~ mmand) Is Nothing) Then
            ~dulla^@204~ apter.UpdateCommand.Connection = valu~dulla^@204~       End If
                Dim i A~dulla^@204~ 
                Do While (i < Me.Co~dulla^@204~ on.Length)
                    If (N~dulla^@204~ dCollection(i)) Is Nothing) Then
   ~dulla^@204~         CType(Me.CommandCollection(i)~dulla^@204~ SqlClient.SqlCommand).Connection = va~dulla^@204~             End If
                 ~dulla^@204~ )
                Loop
            ~dulla^@204~     End Property
        
        <~dulla^@204~ stics.DebuggerNonUserCodeAttribute()>~dulla^@204~ Protected ReadOnly Property CommandCo~dulla^@204~  System.Data.SqlClient.SqlCommand()
~dulla^@204~ et
                If (Me._commandCo~dulla^@204~ othing) Then
                    Me.~dulla^@204~ llection
                End If
   ~dulla^@204~ Return Me._commandCollection
       ~dulla^@204~ 
        End Property
        
    ~dulla^@204~ iagnostics.DebuggerNonUserCodeAttribu~dulla^@204~      Public Property ClearBeforeFill(~dulla^@204~ 
            Get
                Ret~dulla^@204~ BeforeFill
            End Get
    ~dulla^@204~                 Me._clearBeforeFill =~dulla^@204~        End Set
        End Property~dulla^@204~       <System.Diagnostics.DebuggerNon~dulla^@204~ bute()>  _
        Private Sub InitA~dulla^@204~          Me._adapter = New System.Dat~dulla^@204~ qlDataAdapter
            Dim tableM~dulla^@204~ tem.Data.Common.DataTableMapping = Ne~dulla^@204~ .Common.DataTableMapping
           ~dulla^@204~ .SourceTable = "Table"
            t~dulla^@204~ ataSetTable = "SalesInfo"
          ~dulla^@204~ g.ColumnMappings.Add("PartNo", "PartN~dulla^@204~     tableMapping.ColumnMappings.Add("~dulla^@204~  "Description")
            tableMap~dulla^@204~ ppings.Add("Quantity", "Quantity")
 ~dulla^@204~ bleMapping.ColumnMappings.Add("UnitPr~dulla^@204~ ice")
            tableMapping.Colum~dulla^@204~ ("Amount", "Amount")
            Me.~dulla^@204~ eMappings.Add(tableMapping)
        ~dulla^@204~     
        <System.Diagnostics.Deb~dulla^@204~ odeAttribute()>  _
        Private S~dulla^@204~ tion()
            Me._connection = ~dulla^@204~ ta.SqlClient.SqlConnection
         ~dulla^@204~ tion.ConnectionString = Global.Invent~dulla^@204~ tem.My.MySettings.Default.PurchaseInf~dulla^@204~         End Sub
        
        <S~dulla^@204~ tics.DebuggerNonUserCodeAttribute()> ~dulla^@204~ rivate Sub InitCommandCollection()
 ~dulla^@204~ ._commandCollection = New System.Data.SqlClient.SqlCommand(0) {}
            M~dulla^@204~ lection(0) = New System.Data.SqlClien~dulla^@204~ 
            Me._commandCollection(0)~dulla^@204~  Me.Connection
            Me._comma~dulla^@204~ 0).CommandText = "SELECT PartNo, Desc~dulla^@204~ tity, UnitPrice, Amount FROM dbo.Sale~dulla^@204~        Me._commandCollection(0).Comma~dulla^@204~ em.Data.CommandType.Text
        End~dulla^@204~  
        <System.Diagnostics.Debugg~dulla^@204~ Attribute(),  _
         System.Comp~dulla^@204~ sign.HelpKeywordAttribute("vs.data.Ta~dulla^@204~   _
         System.ComponentModel.D~dulla^@204~ odAttribute(System.ComponentModel.Dat~dulla^@204~ Type.Fill, true)>  _
        Public ~dulla^@204~ rridable Function Fill(ByVal dataTabl~dulla^@204~ oDataSet2.SalesInfoDataTable) As Inte~dulla^@204~     Me.Adapter.SelectCommand = Me.Com~dulla^@204~ n(0)
            If (Me.ClearBeforeF~dulla^@204~ hen
                dataTable.Clear~dulla^@204~ End If
            Dim returnValue A~dulla^@204~ e.Adapter.Fill(dataTable)
          ~dulla^@204~ rnValue
        End Function
      ~dulla^@204~ System.Diagnostics.DebuggerNonUserCod~dulla^@204~   _
         System.ComponentModel.D~dulla^@204~ wordAttribute("vs.data.TableAdapter")~dulla^@204~   System.ComponentModel.DataObjectMet~dulla^@204~ System.ComponentModel.DataObjectMetho~dulla^@204~ ], true)>  _
        Public Overload~dulla^@204~  Function GetData() As SalesInfoDataS~dulla^@204~ DataTable
            Me.Adapter.Sel~dulla^@204~ Me.CommandCollection(0)
            ~dulla^@204~  As SalesInfoDataSet2.SalesInfoDataTa~dulla^@204~ esInfoDataSet2.SalesInfoDataTable
  ~dulla^@204~ Adapter.Fill(dataTable)
            ~dulla^@204~ ble
        End Function
    End Class
End Namespace
