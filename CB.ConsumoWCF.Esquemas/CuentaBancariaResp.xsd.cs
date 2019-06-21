namespace CB.ConsumoWCF.Esquemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://CB.ConsumoWCF.Esquemas.CuentaBancariaResp",@"CuentaBancariaResp")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Resultado.CodMensaje", XPath = @"/*[local-name()='CuentaBancariaResp' and namespace-uri()='http://CB.ConsumoWCF.Esquemas.CuentaBancariaResp']/*[local-name()='Resultado' and namespace-uri()='']/*[local-name()='CodMensaje' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Resultado.Mensaje", XPath = @"/*[local-name()='CuentaBancariaResp' and namespace-uri()='http://CB.ConsumoWCF.Esquemas.CuentaBancariaResp']/*[local-name()='Resultado' and namespace-uri()='']/*[local-name()='Mensaje' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"CuentaBancariaResp"})]
    public sealed class CuentaBancariaResp : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://CB.ConsumoWCF.Esquemas.CuentaBancariaResp"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://CB.ConsumoWCF.Esquemas.CuentaBancariaResp"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""CuentaBancariaResp"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='CuentaBancariaResp' and namespace-uri()='http://CB.ConsumoWCF.Esquemas.CuentaBancariaResp']/*[local-name()='Resultado' and namespace-uri()='']/*[local-name()='CodMensaje' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='CuentaBancariaResp' and namespace-uri()='http://CB.ConsumoWCF.Esquemas.CuentaBancariaResp']/*[local-name()='Resultado' and namespace-uri()='']/*[local-name()='Mensaje' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Resultado"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""CodMensaje"" type=""xs:string"" />
              <xs:element name=""Mensaje"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Cuenta"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""Cuentas"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""SaldoActual"" type=""xs:decimal"" />
                    <xs:element name=""TipoCuenta"" type=""xs:int"" />
                    <xs:element name=""Activa"" type=""xs:boolean"" />
                    <xs:element name=""IdCuenta"" type=""xs:string"" />
                    <xs:element name=""NumeroDeCuenta"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public CuentaBancariaResp() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "CuentaBancariaResp";
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
