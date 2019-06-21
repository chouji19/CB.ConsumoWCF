namespace CB.ConsumoWCF.Esquemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Cliente", @"Identificacion", @"CuentaResponse", @"StatusProceso", @"ArrayOfCuenta", @"Cuenta"})]
    public sealed class ServiciosBancarios_hemas_datacontract_org_2004_07_CEB_ProcesosBancarios_Modelos : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""http://schemas.datacontract.org/2004/07/CEB.ProcesosBancarios.Modelos"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.datacontract.org/2004/07/CEB.ProcesosBancarios.Modelos"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:complexType name=""Cliente"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""Identificacion"" nillable=""true"" type=""tns:Identificacion"" />
      <xs:element minOccurs=""0"" name=""Nombres"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""Apellidos"" nillable=""true"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""Cliente"" nillable=""true"" type=""tns:Cliente"" />
  <xs:complexType name=""Identificacion"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""TipoId"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""NumeroIdentificacion"" nillable=""true"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""Identificacion"" nillable=""true"" type=""tns:Identificacion"" />
  <xs:complexType name=""CuentaResponse"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""Resultado"" nillable=""true"" type=""tns:StatusProceso"" />
      <xs:element minOccurs=""0"" name=""cliente"" nillable=""true"" type=""tns:Cliente"" />
      <xs:element minOccurs=""0"" name=""Cuentas"" nillable=""true"" type=""tns:ArrayOfCuenta"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""CuentaResponse"" nillable=""true"" type=""tns:CuentaResponse"" />
  <xs:complexType name=""StatusProceso"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CodRespuesta"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""Mensaje"" nillable=""true"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""StatusProceso"" nillable=""true"" type=""tns:StatusProceso"" />
  <xs:complexType name=""ArrayOfCuenta"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Cuenta"" nillable=""true"" type=""tns:Cuenta"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfCuenta"" nillable=""true"" type=""tns:ArrayOfCuenta"" />
  <xs:complexType name=""Cuenta"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""SaldoActual"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""TipoCuenta"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""activa"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""IdCuenta"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""NumeroCuenta"" nillable=""true"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""Cuenta"" nillable=""true"" type=""tns:Cuenta"" />
</xs:schema>";
        
        public ServiciosBancarios_hemas_datacontract_org_2004_07_CEB_ProcesosBancarios_Modelos() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [6];
                _RootElements[0] = "Cliente";
                _RootElements[1] = "Identificacion";
                _RootElements[2] = "CuentaResponse";
                _RootElements[3] = "StatusProceso";
                _RootElements[4] = "ArrayOfCuenta";
                _RootElements[5] = "Cuenta";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
        
        [Schema(@"http://schemas.datacontract.org/2004/07/CEB.ProcesosBancarios.Modelos",@"Cliente")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Cliente"})]
        public sealed class Cliente : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Cliente() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Cliente";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://schemas.datacontract.org/2004/07/CEB.ProcesosBancarios.Modelos",@"Identificacion")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Identificacion"})]
        public sealed class Identificacion : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Identificacion() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Identificacion";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://schemas.datacontract.org/2004/07/CEB.ProcesosBancarios.Modelos",@"CuentaResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"CuentaResponse"})]
        public sealed class CuentaResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public CuentaResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "CuentaResponse";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://schemas.datacontract.org/2004/07/CEB.ProcesosBancarios.Modelos",@"StatusProceso")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"StatusProceso"})]
        public sealed class StatusProceso : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public StatusProceso() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "StatusProceso";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://schemas.datacontract.org/2004/07/CEB.ProcesosBancarios.Modelos",@"ArrayOfCuenta")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfCuenta"})]
        public sealed class ArrayOfCuenta : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfCuenta() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfCuenta";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://schemas.datacontract.org/2004/07/CEB.ProcesosBancarios.Modelos",@"Cuenta")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Cuenta"})]
        public sealed class Cuenta : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Cuenta() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Cuenta";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
    }
}
