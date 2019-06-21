namespace CB.ConsumoWCF.Mapas {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"CB.ConsumoWCF.Esquemas.CuentaBancariaReq", typeof(global::CB.ConsumoWCF.Esquemas.CuentaBancariaReq))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"CB.ConsumoWCF.Esquemas.ServiciosBancarios_tempuri_org+ObtenerCuentasPorCliente", typeof(global::CB.ConsumoWCF.Esquemas.ServiciosBancarios_tempuri_org.ObtenerCuentasPorCliente))]
    public sealed class CuentaReq_ObtenerCuentaPorCliente : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://tempuri.org/"" xmlns:s0=""http://CB.ConsumoWCF.Esquemas.CuentaBancariaReq"" xmlns:ns1=""http://schemas.datacontract.org/2004/07/CEB.ProcesosBancarios.Modelos"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:CuentaBancariaReq"" />
  </xsl:template>
  <xsl:template match=""/s0:CuentaBancariaReq"">
    <ns0:ObtenerCuentasPorCliente>
      <ns0:cliente>
        <ns1:Identificacion>
          <ns1:TipoId>
            <xsl:value-of select=""TipoIdentificacion/text()"" />
          </ns1:TipoId>
          <ns1:NumeroIdentificacion>
            <xsl:value-of select=""NumeroIdentificacion/text()"" />
          </ns1:NumeroIdentificacion>
        </ns1:Identificacion>
        <ns1:Nombres>
          <xsl:value-of select=""Nombres/text()"" />
        </ns1:Nombres>
        <ns1:Apellidos>
          <xsl:value-of select=""Apellidos/text()"" />
        </ns1:Apellidos>
      </ns0:cliente>
    </ns0:ObtenerCuentasPorCliente>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"CB.ConsumoWCF.Esquemas.CuentaBancariaReq";
        
        private const global::CB.ConsumoWCF.Esquemas.CuentaBancariaReq _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"CB.ConsumoWCF.Esquemas.ServiciosBancarios_tempuri_org+ObtenerCuentasPorCliente";
        
        private const global::CB.ConsumoWCF.Esquemas.ServiciosBancarios_tempuri_org.ObtenerCuentasPorCliente _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"CB.ConsumoWCF.Esquemas.CuentaBancariaReq";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"CB.ConsumoWCF.Esquemas.ServiciosBancarios_tempuri_org+ObtenerCuentasPorCliente";
                return _TrgSchemas;
            }
        }
    }
}
