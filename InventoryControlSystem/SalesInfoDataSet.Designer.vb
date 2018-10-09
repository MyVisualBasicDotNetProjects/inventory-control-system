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
 System.Xml.Serialization.XmlRootAttribute("SalesInfoDataSet"),  _
 System.ComponentModel.Design.HelpKeywordAttribute("vs.data.DataSet")>  _
Partial Public Class SalesInfoDataSet
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
        Dim cln As SalesInfoDataSet = CType(MyBase.Clone,SalesInfoDataSet)
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
            End ~dulla^@204~ ~dulla^@204~ d Sub
    
    <System.Diagnostics.~dulla^@204~ erCodeAttribute()>  _
    Private Su~dulla^@204~ 
        Me.DataSetName = "SalesInfo~dulla^@204~      Me.Prefix = ""
        Me.Names~dulla^@204~ //tempuri.org/SalesInfoDataSet.xsd"
~dulla^@204~ forceConstraints = true
        Me.S~dulla^@204~ ationMode = System.Data.SchemaSeriali~dulla^@204~ cludeSchema
        Me.tableSalesInf~dulla^@204~ InfoDataTable
        MyBase.Tables.~dulla^@204~ alesInfo)
    End Sub
    
    <Sy~dulla^@204~ ics.DebuggerNonUserCodeAttribute()>  ~dulla^@204~ e Function ShouldSerializeSalesInfo()~dulla^@204~         Return false
    End Functio~dulla^@204~ <System.Diagnostics.DebuggerNonUserCo~dulla^@204~ >  _
    Private Sub SchemaChanged(B~dulla^@204~ s Object, ByVal e As System.Component~dulla^@204~ ionChangeEventArgs)
        If (e.Ac~dulla^@204~ .ComponentModel.CollectionChangeActio~dulla^@204~ n
            Me.InitVars
        E~dulla^@204~ d Sub
    
    <System.Diagnostics.~dulla^@204~ erCodeAttribute()>  _
    Public Sha~dulla^@204~ GetTypedDataSetSchema(ByVal xs As Sys~dulla^@204~ a.XmlSchemaSet) As System.Xml.Schema.~dulla^@204~ lexType
        Dim ds As SalesInfoD~dulla^@204~ SalesInfoDataSet
        Dim type As~dulla^@204~ chema.XmlSchemaComplexType = New Syst~dulla^@204~ .XmlSchemaComplexType
        Dim se~dulla^@204~ tem.Xml.Schema.XmlSchemaSequence = Ne~dulla^@204~ Schema.XmlSchemaSequence
        xs.~dulla^@204~ emaSerializable)
        Dim any As ~dulla^@204~ hema.XmlSchemaAny = New System.Xml.Sc~dulla^@204~ aAny
        any.Namespace = ds.Name~dulla^@204~   sequence.Items.Add(any)
        ty~dulla^@204~  sequence
        Return type
    E~dulla^@204~     
    Public Delegate Sub SalesIn~dulla^@204~ entHandler(ByVal sender As Object, By~dulla^@204~ sInfoRowChangeEvent)
    
    <Syst~dulla^@204~ mpiler.GeneratedCodeAttribute("System~dulla^@204~ TypedDataSetGenerator", "2.0.0.0"),  ~dulla^@204~ m.Serializable(),  _
     System.Xml~dulla^@204~ n.XmlSchemaProviderAttribute("GetType~dulla^@204~ )>  _
    Partial Public Class Sales~dulla^@204~ 
        Inherits System.Data.DataTa~dulla^@204~ Implements System.Collections.IEnumer~dulla^@204~  
        Private columnPartNo As Sy~dulla^@204~ aColumn
        
        Private co~dulla^@204~ on As System.Data.DataColumn
       ~dulla^@204~ ivate columnQuantity As System.Data.D~dulla^@204~       
        Private columnUnitPri~dulla^@204~ Data.DataColumn
        
        Pr~dulla^@204~ mount As System.Data.DataColumn
    ~dulla^@204~  Private columnDateOfSale As System.D~dulla^@204~ n
        
        <System.Diagnost~dulla^@204~ onUserCodeAttribute()>  _
        Pu~dulla^@204~ )
            MyBase.New
          ~dulla^@204~ e = "SalesInfo"
            Me.Begin~dulla^@204~      Me.InitClass
            Me.End~dulla^@204~  End Sub
        
        <System.D~dulla^@204~ buggerNonUserCodeAttribute()>  _
   ~dulla^@204~ ub New(ByVal table As System.Data.Dat~dulla^@204~         MyBase.New
            Me.Ta~dulla^@204~ le.TableName
            If (table.C~dulla^@204~ <> table.DataSet.CaseSensitive) Then
            If (table.L~dulla^@204~ g <> table.DataSet.Locale.ToString) T~dulla^@204~         Me.Locale = table.Locale
   ~dulla^@204~ If
            If (table.Namespace <~dulla^@204~ et.Namespace) Then
                M~dulla^@204~  table.Namespace
            End If
           ~dulla^@204~ pacity = table.MinimumCapacity
     ~dulla^@204~        
        <System.Diagnostics.~dulla^@204~ erCodeAttribute()>  _
        Protec~dulla^@204~ yVal info As System.Runtime.Serializa~dulla^@204~ ationInfo, ByVal context As System.Ru~dulla^@204~ zation.StreamingContext)
           ~dulla^@204~ nfo, context)
            Me.InitVar~dulla^@204~ d Sub
        
        <System.Diag~dulla^@204~ gerNonUserCodeAttribute()>  _
      ~dulla^@204~ Only Property PartNoColumn() As Syste~dulla^@204~ lumn
            Get
              ~dulla^@204~ olumnPartNo
            End Get
   ~dulla^@204~ erty
        
        <System.Diagn~dulla^@204~ erNonUserCodeAttribute()>  _
       ~dulla^@204~ nly Property DescriptionColumn() As S~dulla^@204~ taColumn
            Get
          ~dulla^@204~ Me.columnDescription
            End~dulla^@204~  End Property
        
        <Sys~dulla^@204~ cs.DebuggerNonUserCodeAttribute()>  _~dulla^@204~ lic ReadOnly Property QuantityColumn(~dulla^@204~ ata.DataColumn
            Get
    ~dulla^@204~ eturn Me.columnQuantity
            ~dulla^@204~     End Property
        
        <~dulla^@204~ stics.DebuggerNonUserCodeAttribute()>~dulla^@204~ Public ReadOnly Property UnitPriceCol~dulla^@204~ em.Data.DataColumn
            Get
~dulla^@204~    Return Me.columnUnitPrice
       ~dulla^@204~ 
        End Property
        
    ~dulla^@204~ iagnostics.DebuggerNonUserCodeAttribu~dulla^@204~      Public ReadOnly Property AmountC~dulla^@204~ stem.Data.DataColumn
            Get~dulla^@204~      Return Me.columnAmount
        ~dulla^@204~         End Property
        
     ~dulla^@204~ agnostics.DebuggerNonUserCodeAttribut~dulla^@204~     Public ReadOnly Property DateOfSa~dulla^@204~  System.Data.DataColumn
            ~dulla^@204~         Return Me.columnDateOfSale
 ~dulla^@204~ d Get
        End Property
        ~dulla^@204~ stem.Diagnostics.DebuggerNonUserCodeA~dulla^@204~ _
         System.ComponentModel.Bro~dulla^@204~ >  _
        Public ReadOnly Propert~dulla^@204~ Integer
            Get
           ~dulla^@204~ e.Rows.Count
            End Get
  ~dulla^@204~ perty
        
        <System.Diag~dulla^@204~ gerNonUserCodeAttribute()>  _
      ~dulla^@204~ ult ReadOnly Property Item(ByVal inde~dulla^@204~  As SalesInfoRow
            Get
  ~dulla^@204~  Return CType(Me.Rows(index),SalesInf~dulla^@204~       End Get
        End Property
~dulla^@204~      Public Event SalesInfoRowChangin~dulla^@204~ oRowChangeEventHandler
        
   ~dulla^@204~ vent SalesInfoRowChanged As SalesInfo~dulla^@204~ tHandler
        
        Public Ev~dulla^@204~ RowDeleting As SalesInfoRowChangeEven~dulla^@204~      
        Public Event SalesInfo~dulla^@204~  SalesInfoRowChangeEventHandler
    ~dulla^@204~  <System.Diagnostics.DebuggerNonUserC~dulla^@204~ )>  _
        Public Overloads Sub A~dulla^@204~ w(ByVal row As SalesInfoRow)
       ~dulla^@204~ Add(row)
        End Sub
        
~dulla^@204~ em.Diagnostics.DebuggerNonUserCodeAtt~dulla^@204~ 
        Public Overloads Function Ad~dulla^@204~ (ByVal PartNo As String, ByVal Descri~dulla^@204~ ng, ByVal Quantity As Integer, ByVal ~dulla^@204~ Decimal, ByVal Amount As Decimal, ByV~dulla^@204~  As Date) As SalesInfoRow
          ~dulla^@204~ sInfoRow As SalesInfoRow = CType(Me.N~dulla^@204~ foRow)
            rowSalesInfoRow.I~dulla^@204~ w Object() {PartNo, Description, Quan~dulla^@204~ ce, Amount, DateOfSale}
            ~dulla^@204~ owSalesInfoRow)
            Return r~dulla^@204~ w
        End Function
        
  ~dulla^@204~ .Diagnostics.DebuggerNonUserCodeAttri~dulla^@204~        Public Overridable Function Ge~dulla^@204~  As System.Collections.IEnumerator Im~dulla^@204~ em.Collections.IEnumerable.GetEnumera~dulla^@204~     Return Me.Rows.GetEnumerator
   ~dulla^@204~ tion
        
        <System.Diagn~dulla^@204~ erNonUserCodeAttribute()>  _
       ~dulla^@204~ ides Function Clone() As System.Data.~dulla^@204~           Dim cln As SalesInfoDataTab~dulla^@204~ Base.Clone,SalesInfoDataTable)
     ~dulla^@204~ itVars
            Return cln
     ~dulla^@204~ on
        
        <System.Diagnos~dulla^@204~ NonUserCodeAttribute()>  _
        P~dulla^@204~ rides Function CreateInstance() As Sy~dulla^@204~ aTable
            Return New SalesI~dulla^@204~ 
        End Function
        
    ~dulla^@204~ iagnostics.DebuggerNonUserCodeAttribu~dulla^@204~      Friend Sub InitVars()
         ~dulla^@204~ artNo = MyBase.Columns("PartNo")
   ~dulla^@204~ olumnDescription = MyBase.Columns("Description")
            Me.columnQuantity~dulla^@204~ umns("Quantity")
            Me.colu~dulla^@204~  MyBase.Columns("UnitPrice")
       ~dulla^@204~ nAmount = MyBase.Columns("Amount")
 ~dulla^@204~ .columnDateOfSale = MyBase.Columns("D~dulla^@204~         End Sub
        
        <S~dulla^@204~ tics.DebuggerNonUserCodeAttribute()> ~dulla^@204~ rivate Sub InitClass()
            M~dulla^@204~ o = New System.Data.DataColumn("PartN~dulla^@204~ tring), Nothing, System.Data.MappingT~dulla^@204~ 
            MyBase.Columns.Add(Me.co~dulla^@204~             Me.columnDescription = Ne~dulla^@204~ .DataColumn("Description", GetType(St~dulla^@204~ g, System.Data.MappingType.Element)
~dulla^@204~ yBase.Columns.Add(Me.columnDescriptio~dulla^@204~    Me.columnQuantity = New System.Dat~dulla^@204~ "Quantity", GetType(Integer), Nothing~dulla^@204~ .MappingType.Element)
            My~dulla^@204~ Add(Me.columnQuantity)
            M~dulla^@204~ rice = New System.Data.DataColumn("Un~dulla^@204~ Type(Decimal), Nothing, System.Data.M~dulla^@204~ ement)
            MyBase.Columns.Ad~dulla^@204~ itPrice)
            Me.columnAmount~dulla^@204~ .Data.DataColumn("Amount", GetType(De~dulla^@204~ ng, System.Data.MappingType.Element)
~dulla^@204~ e.columnDateOfSale = New System.Data.~dulla^@204~ ateOfSale", GetType(Date), Nothing, S~dulla^@204~ ppingType.Element)
            MyBas~dulla^@204~ (Me.columnDateOfSale)
            Me~dulla^@204~ .AllowDBNull = false
            Me.~dulla^@204~ MaxLength = 20
            Me.column~dulla^@204~ axLength = 20
        End Sub
     ~dulla^@204~ <System.Diagnostics.DebuggerNonUserCo~dulla^@204~ >  _
        Public Function NewSale~dulla^@204~  SalesInfoRow
            Return CTy~dulla^@204~ SalesInfoRow)
        End Function
~dulla^@204~      <System.Diagnostics.DebuggerNonU~dulla^@204~ ute()>  _
        Protected Override~dulla^@204~ wRowFromBuilder(ByVal builder As Syst~dulla^@204~ owBuilder) As System.Data.DataRow
  ~dulla^@204~ urn New SalesInfoRow(builder)
      ~dulla^@204~ n
        
        <System.Diagnost~dulla^@204~ onUserCodeAttribute()>  _
        Pr~dulla^@204~ ides Function GetRowType() As System.~dulla^@204~      Return GetType(SalesInfoRow)
  ~dulla^@204~ ction
        
        <System.Diag~dulla^@204~ gerNonUserCodeAttribute()>  _
      ~dulla^@204~ verrides Sub OnRowChanged(ByVal e As ~dulla^@204~ ataRowChangeEventArgs)
            M~dulla^@204~ anged(e)
            If (Not (Me.Sal~dulla^@204~ gedEvent) Is Nothing) Then
         ~dulla^@204~ vent SalesInfoRowChanged(Me, New Sale~dulla^@204~ eEvent(CType(e.Row,SalesInfoRow), e.A~dulla^@204~         End If
        End Sub
    ~dulla^@204~  <System.Diagnostics.DebuggerNonUserC~dulla^@204~ )>  _
        Protected Overrides Su~dulla^@204~ ng(ByVal e As System.Data.DataRowChan~dulla^@204~ 
            MyBase.OnRowChanging(e)
                RaiseEvent Sal~dulla^@204~ ging(Me, New SalesInfoRowChangeEvent(~dulla^@204~ alesInfoRow), e.Action))
           ~dulla^@204~     End Sub
        
        <Syste~dulla^@204~ .DebuggerNonUserCodeAttribute()>  _
~dulla^@204~ cted Overrides Sub OnRowDeleted(ByVal~dulla^@204~ Data.DataRowChangeEventArgs)
       ~dulla^@204~ nRowDeleted(e)
            If (Not (~dulla^@204~ owDeletedEvent) Is Nothing) Then
   ~dulla^@204~ RaiseEvent SalesInfoRowDeleted(Me, Ne~dulla^@204~ wChangeEvent(CType(e.Row,SalesInfoRow~dulla^@204~ 
            End If
        End Sub~dulla^@204~        <System.Diagnostics.DebuggerNo~dulla^@204~ ibute()>  _
        Protected Overri~dulla^@204~ Deleting(ByVal e As System.Data.DataR~dulla^@204~ Args)
            MyBase.OnRowDeleti~dulla^@204~       If (Not (Me.SalesInfoRowDeletin~dulla^@204~ thing) Then
                RaiseEve~dulla^@204~ owDeleting(Me, New SalesInfoRowChange~dulla^@204~ .Row,SalesInfoRow), e.Action))
     ~dulla^@204~ 
        End Sub
        
        ~dulla^@204~ ostics.DebuggerNonUserCodeAttribute()~dulla^@204~  Public Sub RemoveSalesInfoRow(ByVal ~dulla^@204~ nfoRow)
            Me.Rows.Remove(r~dulla^@204~ End Sub
        
        <System.Di~dulla^@204~ uggerNonUserCodeAttribute()>  _
    ~dulla^@204~ ared Function GetTypedTableSchema(ByV~dulla^@204~ em.Xml.Schema.XmlSchemaSet) As System~dulla^@204~ mlSchemaComplexType
            Dim ~dulla^@204~ m.Xml.Schema.XmlSchemaComplexType = N~dulla^@204~ .Schema.XmlSchemaComplexType
       ~dulla^@204~ ence As System.Xml.Schema.XmlSchemaSe~dulla^@204~ System.Xml.Schema.XmlSchemaSequence
~dulla^@204~ im ds As SalesInfoDataSet = New Sales~dulla^@204~             xs.Add(ds.GetSchemaSerial~dulla^@204~         Dim any1 As System.Xml.Schema~dulla^@204~  = New System.Xml.Schema.XmlSchemaAny~dulla^@204~  any1.Namespace = "http://www.w3.org/~dulla^@204~ a"
            any1.MinOccurs = New ~dulla^@204~            any1.MaxOccurs = Decimal.M~dulla^@204~         any1.ProcessContents = System~dulla^@204~ mlSchemaContentProcessing.Lax
      ~dulla^@204~ e.Items.Add(any1)
            Dim an~dulla^@204~ Xml.Schema.XmlSchemaAny = New System.~dulla^@204~ lSchemaAny
            any2.Namespac~dulla^@204~ mas-microsoft-com:xml-diffgram-v1"
 ~dulla^@204~ y2.MinOccurs = New Decimal(1)
      ~dulla^@204~ ocessContents = System.Xml.Schema.Xml~dulla^@204~ Processing.Lax
            sequence.~dulla^@204~ 2)
            Dim attribute1 As Sys~dulla^@204~ a.XmlSchemaAttribute = New System.Xml~dulla^@204~ hemaAttribute
            attribute1~dulla^@204~ space"
            attribute1.FixedV~dulla^@204~ espace
            type.Attributes.A~dulla^@204~ )
            Dim attribute2 As Syst~dulla^@204~ .XmlSchemaAttribute = New System.Xml.~dulla^@204~ emaAttribute
            attribute2.~dulla^@204~ TypeName"
            attribute2.Fix~dulla^@204~ lesInfoDataTable"
            type.A~dulla^@204~ (attribute2)
            type.Partic~dulla^@204~ 
            Return type
        En~dulla^@204~    End Class
    
    <System.CodeD~dulla^@204~ eneratedCodeAttribute("System.Data.De~dulla^@204~ aSetGenerator", "2.0.0.0")>  _
    P~dulla^@204~  Class SalesInfoRow
        Inherits~dulla^@204~ DataRow
        
        Private ta~dulla^@204~ As SalesInfoDataTable
        
    ~dulla^@204~ iagnostics.DebuggerNonUserCodeAttribu~dulla^@204~      Friend Sub New(ByVal rb As Syste~dulla^@204~ wBuilder)
            MyBase.New(rb)~dulla^@204~  Me.tableSalesInfo = CType(Me.Table,S~dulla^@204~ able)
        End Sub
        
   ~dulla^@204~ Diagnostics.DebuggerNonUserCodeAttrib~dulla^@204~       Public Property PartNo() As Str~dulla^@204~     Get
                Return CType~dulla^@204~ alesInfo.PartNoColumn),String)
     ~dulla^@204~ t
            Set
                M~dulla^@204~ esInfo.PartNoColumn) = value
       ~dulla^@204~ 
        End Property
        
    ~dulla^@204~ iagnostics.DebuggerNonUserCodeAttribu~dulla^@204~      Public Property Description() As~dulla^@204~         Get
                Try 
  ~dulla^@204~      Return CType(Me(Me.tableSalesInf~dulla^@204~ Column),String)
                Catc~dulla^@204~ .InvalidCastException
              ~dulla^@204~ ew System.Data.StrongTypingException(~dulla^@204~ r column 'Description' in table 'Sale~dulla^@204~ ull.", e)
                End Try
 ~dulla^@204~ d Get
            Set
             ~dulla^@204~ eSalesInfo.DescriptionColumn) = value~dulla^@204~  End Set
        End Property
     ~dulla^@204~ <System.Diagnostics.DebuggerNonUserCo~dulla^@204~ >  _
        Public Property Quantit~dulla^@204~ r
            Get
                T~dulla^@204~             Return CType(Me(Me.tableS~dulla^@204~ tityColumn),Integer)
               ~dulla^@204~ ystem.InvalidCastException
         ~dulla^@204~ row New System.Data.StrongTypingExcep~dulla^@204~ ue for column 'Quantity' in table 'Sa~dulla^@204~ BNull.", e)
                End Try
            Set
           ~dulla^@204~ bleSalesInfo.QuantityColumn) = value
        End Property
      ~dulla^@204~ System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property ~dulla^@204~ s Decimal
            Get
         ~dulla^@204~                     Return CType(Me(M~dulla^@204~ nfo.UnitPriceColumn),Decimal)
      ~dulla^@204~ ch e As System.InvalidCastException
~dulla^@204~        Throw New System.Data.StrongTy~dulla^@204~ ("The value for column 'UnitPrice' in~dulla^@204~ Info' is DBNull.", e)
              ~dulla^@204~           End Get
            Set
 ~dulla^@204~   Me(Me.tableSalesInfo.UnitPriceColum~dulla^@204~            End Set
        End Prope~dulla^@204~ 
        <System.Diagnostics.Debugge~dulla^@204~ ttribute()>  _
        Public Proper~dulla^@204~ s Decimal
            Get
         ~dulla^@204~                     Return CType(Me(M~dulla^@204~ nfo.AmountColumn),Decimal)
         ~dulla^@204~ e As System.InvalidCastException
   ~dulla^@204~     Throw New System.Data.StrongTypin~dulla^@204~ he value for column 'Amount' in table~dulla^@204~ is DBNull.", e)
                End ~dulla^@204~     End Get
            Set
       ~dulla^@204~ e.tableSalesInfo.AmountColumn) = valu~dulla^@204~   End Set
        End Property
    ~dulla^@204~  <System.Diagnostics.DebuggerNonUserC~dulla^@204~ )>  _
        Public Property DateOf~dulla^@204~ e
            Get
                T~dulla^@204~             Return CType(Me(Me.tableS~dulla^@204~ OfSaleColumn),Date)
                ~dulla^@204~ stem.InvalidCastException
          ~dulla^@204~ ow New System.Data.StrongTypingExcept~dulla^@204~ e for column 'DateOfSale' in table 'S~dulla^@204~ DBNull.", e)
                End Try~dulla^@204~  End Get
            Set
          ~dulla^@204~ ableSalesInfo.DateOfSaleColumn) = val~dulla^@204~    End Set
        End Property
   ~dulla^@204~   <System.Diagnostics.DebuggerNonUser~dulla^@204~ ()>  _
        Public Function IsDes~dulla^@204~ ) As Boolean
            Return Me.I~dulla^@204~ eSalesInfo.DescriptionColumn)
      ~dulla^@204~ n
        
        <System.Diagnost~dulla^@204~ onUserCodeAttribute()>  _
        Pu~dulla^@204~ escriptionNull()
            Me(Me.t~dulla^@204~ .DescriptionColumn) = System.Convert.~dulla^@204~    End Sub
        
        <System~dulla^@204~ DebuggerNonUserCodeAttribute()>  _
 ~dulla^@204~  Function IsQuantityNull() As Boolean~dulla^@204~  Return Me.IsNull(Me.tableSalesInfo.Q~dulla^@204~ )
        End Function
        
  ~dulla^@204~ .Diagnostics.DebuggerNonUserCodeAttri~dulla^@204~        Public Sub SetQuantityNull()
~dulla^@204~ e(Me.tableSalesInfo.QuantityColumn) =~dulla^@204~ rt.DBNull
        End Sub
        
        Public Function IsUnitPrice~dulla^@204~ lean
            Return Me.IsNull(Me~dulla^@204~ fo.UnitPriceColumn)
        End Func~dulla^@204~  
        <System.Diagnostics.Debugg~dulla^@204~ Attribute()>  _
        Public Sub S~dulla^@204~ ll()
            Me(Me.tableSalesInf~dulla^@204~ lumn) = System.Convert.DBNull
      ~dulla^@204~       
        <System.Diagnostics.D~dulla^@204~ rCodeAttribute()>  _
        Public ~dulla^@204~ ountNull() As Boolean
            Re~dulla^@204~ l(Me.tableSalesInfo.AmountColumn)
  ~dulla^@204~ ction
        
        <System.Diag~dulla^@204~ gerNonUserCodeAttribute()>  _
      ~dulla^@204~ SetAmountNull()
            Me(Me.ta~dulla^@204~ AmountColumn) = System.Convert.DBNull~dulla^@204~  Sub
        
        <System.Diagn~dulla^@204~ erNonUserCodeAttribute()>  _
       ~dulla^@204~ ion IsDateOfSaleNull() As Boolean
  ~dulla^@204~ urn Me.IsNull(Me.tableSalesInfo.DateO~dulla^@204~ 
        End Function
        
    ~dulla^@204~ iagnostics.DebuggerNonUserCodeAttribu~dulla^@204~      Public Sub SetDateOfSaleNull()
~dulla^@204~ e(Me.tableSalesInfo.DateOfSaleColumn)~dulla^@204~ vert.DBNull
        End Sub
    End~dulla^@204~ 
    <System.CodeDom.Compiler.Generat~dulla^@204~ te("System.Data.Design.TypedDataSetGe~dulla^@204~ 0.0.0")>  _
    Public Class SalesIn~dulla^@204~ ent
        Inherits System.EventArg~dulla^@204~         Private eventRow As SalesInfo~dulla^@204~ 
        Private eventAction As Syst~dulla^@204~ owAction
        
        <System.D~dulla^@204~ buggerNonUserCodeAttribute()>  _
   ~dulla^@204~ ub New(ByVal row As SalesInfoRow, ByV~dulla^@204~ System.Data.DataRowAction)
         ~dulla^@204~ 
            Me.eventRow = row
    ~dulla^@204~ entAction = action
        End Sub
~dulla^@204~      <System.Diagnostics.DebuggerNonU~dulla^@204~ ute()>  _
        Public ReadOnly Pr~dulla^@204~ As SalesInfoRow
            Get
   ~dulla^@204~ Return Me.eventRow
            End G~dulla^@204~ nd Property
        
        <Syste~dulla^@204~ .DebuggerNonUserCodeAttribute()>  _
~dulla^@204~ c ReadOnly Property Action() As Syste~dulla^@204~ wAction
            Get
           ~dulla^@204~ e.eventAction
            End Get
 ~dulla^@204~ operty
    End Class
End Class

N~dulla^@204~ sInfoDataSetTableAdapters
    
    ~dulla^@204~ om.Compiler.GeneratedCodeAttribute("S~dulla^@204~ sign.TypedDataSetGenerator", "2.0.0.0~dulla^@204~ System.ComponentModel.DesignerCategor~dulla^@204~ ode"),  _
     System.ComponentModel~dulla^@204~ true),  _
     System.ComponentModel~dulla^@204~ tribute(true),  _
     System.Compon~dulla^@204~ gnerAttribute("Microsoft.VSDesigner.D~dulla^@204~ ign.TableAdapterDesigner, Microsoft.V~dulla^@204~  
        ", Version=8.0.0.0, Cultur~dulla^@204~ blicKeyToken=b03f5f7f11d50a3a"),  _
~dulla^@204~ omponentModel.Design.HelpKeywordAttri~dulla^@204~ .TableAdapter")>  _
    Partial Publ~dulla^@204~ sInfoTableAdapter
        Inherits S~dulla^@204~ ntModel.Component
        
        ~dulla^@204~ vents _adapter As System.Data.SqlClie~dulla^@204~ pter
        
        Private _conn~dulla^@204~ tem.Data.SqlClient.SqlConnection
   ~dulla^@204~   Private _commandCollection() As Sys~dulla^@204~ lient.SqlCommand
        
        P~dulla^@204~ BeforeFill As Boolean
        
    ~dulla^@204~ iagnostics.DebuggerNonUserCodeAttribu~dulla^@204~      Public Sub New()
            My~dulla^@204~          Me.ClearBeforeFill = true
 ~dulla^@204~ b
        
        <System.Diagnost~dulla^@204~ onUserCodeAttribute()>  _
        Pr~dulla^@204~ y Property Adapter() As System.Data.S~dulla^@204~ ataAdapter
            Get
        ~dulla^@204~ e._adapter Is Nothing) Then
        ~dulla^@204~ e.InitAdapter
                End If~dulla^@204~      Return Me._adapter
            ~dulla^@204~     End Property
        
        <~dulla^@204~ stics.DebuggerNonUserCodeAttribute()>~dulla^@204~ Friend Property Connection() As Syste~dulla^@204~ ent.SqlConnection
            Get
 ~dulla^@204~   If (Me._connection Is Nothing) Then~dulla^@204~          Me.InitConnection
         ~dulla^@204~ 
                Return Me._connecti~dulla^@204~    End Get
            Set
        ~dulla^@204~ onnection = value
                If~dulla^@204~ pter.InsertCommand) Is Nothing) Then
                End If
          ~dulla^@204~  (Me.Adapter.DeleteCommand) Is Nothin~dulla^@204~                 Me.Adapter.DeleteComm~dulla^@204~ n = value
                End If
  ~dulla^@204~  If (Not (Me.Adapter.UpdateCommand) I~dulla^@204~ en
                    Me.Adapter.Up~dulla^@204~ onnection = value
                En~dulla^@204~          Dim i As Integer = 0
      ~dulla^@204~ While (i < Me.CommandCollection.Lengt~dulla^@204~            If (Not (Me.CommandCollect~dulla^@204~ thing) Then
                        ~dulla^@204~ andCollection(i),System.Data.SqlClien~dulla^@204~ .Connection = value
                ~dulla^@204~                    i = (i + 1)
     ~dulla^@204~ op
            End Set
        End ~dulla^@204~      
        <System.Diagnostics.De~dulla^@204~ CodeAttribute()>  _
        Protecte~dulla^@204~ operty CommandCollection() As System.~dulla^@204~ t.SqlCommand()
            Get
    ~dulla^@204~ f (Me._commandCollection Is Nothing) ~dulla^@204~              Me.InitCommandCollection~dulla^@204~      End If
                Return M~dulla^@204~ lection
            End Get
        End Property
        
        <System.D~dulla^@204~ buggerNonUserCodeAttribute()>  _
   ~dulla^@204~ roperty ClearBeforeFill() As Boolean
                Return Me._clear~dulla^@204~            End Get
            Set
~dulla^@204~    Me._clearBeforeFill = value
     ~dulla^@204~ t
        End Property
        
  ~dulla^@204~ .Diagnostics.DebuggerNonUserCodeAttri~dulla^@204~        Private Sub InitAdapter()
   ~dulla^@204~ adapter = New System.Data.SqlClient.S~dulla^@204~ 
            Dim tableMapping As Sys~dulla^@204~ on.DataTableMapping = New System.Data~dulla^@204~ ableMapping
            tableMapping~dulla^@204~ = "Table"
            tableMapping.D~dulla^@204~  "SalesInfo"
            tableMappin~dulla^@204~ ngs.Add("PartNo", "PartNo")
        ~dulla^@204~ ing.ColumnMappings.Add("Description",~dulla^@204~ ")
            tableMapping.ColumnMa~dulla^@204~ uantity", "Quantity")
            ta~dulla^@204~ lumnMappings.Add("UnitPrice", "UnitPr~dulla^@204~       tableMapping.ColumnMappings.Add~dulla^@204~ mount")
            tableMapping.Col~dulla^@204~ dd("DateOfSale", "DateOfSale")
     ~dulla^@204~ apter.TableMappings.Add(tableMapping)~dulla^@204~  Sub
        
        <System.Diagn~dulla^@204~ erNonUserCodeAttribute()>  _
       ~dulla^@204~ InitConnection()
            Me._con~dulla^@204~  System.Data.SqlClient.SqlConnection
        End Sub
        
~dulla^@204~ em.Diagnostics.DebuggerNonUserCodeAtt~dulla^@204~ 
        Private Sub InitCommandColle~dulla^@204~         Me._commandCollection = New S~dulla^@204~ lClient.SqlCommand(0) {}
           ~dulla^@204~ ollection(0) = New System.Data.SqlCli~dulla^@204~ d
            Me._commandCollection(~dulla^@204~  = Me.Connection
            Me._com~dulla^@204~ n(0).CommandText = "SELECT PartNo, De~dulla^@204~ antity, UnitPrice, Amount, DateOfSale~dulla^@204~ e"& _ 
                "sInfo"
    ~dulla^@204~ ommandCollection(0).CommandType = Sys~dulla^@204~ andType.Text
        End Sub
      ~dulla^@204~ System.Diagnostics.DebuggerNonUserCod~dulla^@204~   _
         System.ComponentModel.D~dulla^@204~ wordAttribute("vs.data.TableAdapter")~dulla^@204~   System.ComponentModel.DataObjectMet~dulla^@204~ System.ComponentModel.DataObjectMetho~dulla^@204~ rue)>  _
        Public Overloads Ov~dulla^@204~ ction Fill(ByVal dataTable As SalesIn~dulla^@204~ esInfoDataTable) As Integer
        ~dulla^@204~ r.SelectCommand = Me.CommandCollectio~dulla^@204~      If (Me.ClearBeforeFill = true) T~dulla^@204~         dataTable.Clear
            ~dulla^@204~        Dim returnValue As Integer = M~dulla^@204~ l(dataTable)
            Return retu~dulla^@204~     End Function
        
        <~dulla^@204~ stics.DebuggerNonUserCodeAttribute(),~dulla^@204~  System.ComponentModel.Design.HelpKey~dulla^@204~ ("vs.data.TableAdapter"),  _
       ~dulla^@204~ onentModel.DataObjectMethodAttribute(~dulla^@204~ entModel.DataObjectMethodType.[Select~dulla^@204~ 
        Public Overloads Overridable~dulla^@204~ Data() As SalesInfoDataSet.SalesInfoD~dulla^@204~          Me.Adapter.SelectCommand = M~dulla^@204~ ection(0)
            Dim dataTable ~dulla^@204~ ataSet.SalesInfoDataTable = New Sales~dulla^@204~ alesInfoDataTable
            Me.Ada~dulla^@204~ aTable)
            Return dataTable~dulla^@204~  Function
    End Class
End Namespace