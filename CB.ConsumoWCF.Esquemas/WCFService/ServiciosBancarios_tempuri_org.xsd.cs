namespace CB.ConsumoWCF.Esquemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ObtenerCuentasPorCliente", @"ObtenerCuentasPorClienteResponse"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"CB.ConsumoWCF.Esquemas.ServiciosBancarios_hemas_datacontract_org_2004_07_CEB_ProcesosBancarios_Modelos", typeof(global::CB.ConsumoWCF.Esquemas.ServiciosBancarios_hemas_datacontract_org_2004_07_CEB_ProcesosBancarios_Modelos))]
    public sealed class ServiciosBancarios_tempuri_org : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""http://tempuri.org/"" elementFormDefault=""qualified"" targetNamespace=""http://tempuri.org/"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""CB.ConsumoWCF.Esquemas.ServiciosBancarios_hemas_datacontract_org_2004_07_CEB_ProcesosBancarios_Modelos"" namespace=""http://schemas.datacontract.org/2004/07/CEB.ProcesosBancarios.Modelos"" />
  <xs:annotation>
    <xs:appinfo>
      <references xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
        <reference targetNamespace=""http://schemas.datacontract.org/2004/07/CEB.ProcesosBancarios.Modelos"" />
      </references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""ObtenerCuentasPorCliente"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q1=""http://schemas.datacontract.org/2004/07/CEB.ProcesosBancarios.Modelos"" minOccurs=""0"" name=""cliente"" nillable=""true"" type=""q1:Cliente"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ObtenerCuentasPorClienteResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q2=""http://schemas.datacontract.org/2004/07/CEB.ProcesosBancarios.Modelos"" minOccurs=""0"" name=""ObtenerCuentasPorClienteResult"" nillable=""true"" type=""q2:CuentaResponse"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public ServiciosBancarios_tempuri_org() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "ObtenerCuentasPorCliente";
                _RootElements[1] = "ObtenerCuentasPorClienteResponse";
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
        
        [Schema(@"http://tempuri.org/",@"ObtenerCuentasPorCliente")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ObtenerCuentasPorCliente"})]
        public sealed class ObtenerCuentasPorCliente : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ObtenerCuentasPorCliente() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ObtenerCuentasPorCliente";
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
        
        [Schema(@"http://tempuri.org/",@"ObtenerCuentasPorClienteResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ObtenerCuentasPorClienteResponse"})]
        public sealed class ObtenerCuentasPorClienteResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ObtenerCuentasPorClienteResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ObtenerCuentasPorClienteResponse";
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
