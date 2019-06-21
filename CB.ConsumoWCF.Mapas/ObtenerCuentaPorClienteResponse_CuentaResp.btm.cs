namespace CB.ConsumoWCF.Mapas {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"CB.ConsumoWCF.Esquemas.ServiciosBancarios_tempuri_org+ObtenerCuentasPorClienteResponse", typeof(global::CB.ConsumoWCF.Esquemas.ServiciosBancarios_tempuri_org.ObtenerCuentasPorClienteResponse))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"CB.ConsumoWCF.Esquemas.CuentaBancariaResp", typeof(global::CB.ConsumoWCF.Esquemas.CuentaBancariaResp))]
    public sealed class ObtenerCuentaPorClienteResponse_CuentaResp : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 s1"" version=""1.0"" xmlns:s1=""http://tempuri.org/"" xmlns:ns0=""http://CB.ConsumoWCF.Esquemas.CuentaBancariaResp"" xmlns:s0=""http://schemas.datacontract.org/2004/07/CEB.ProcesosBancarios.Modelos"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s1:ObtenerCuentasPorClienteResponse"" />
  </xsl:template>
  <xsl:template match=""/s1:ObtenerCuentasPorClienteResponse"">
    <ns0:CuentaBancariaResp>
      <xsl:for-each select=""s1:ObtenerCuentasPorClienteResult"">
        <xsl:for-each select=""s0:Resultado"">
          <Resultado>
            <xsl:if test=""s0:CodRespuesta"">
              <CodMensaje>
                <xsl:value-of select=""s0:CodRespuesta/text()"" />
              </CodMensaje>
            </xsl:if>
            <xsl:if test=""s0:Mensaje"">
              <Mensaje>
                <xsl:value-of select=""s0:Mensaje/text()"" />
              </Mensaje>
            </xsl:if>
          </Resultado>
        </xsl:for-each>
      </xsl:for-each>
      <Cuenta>
        <xsl:for-each select=""s1:ObtenerCuentasPorClienteResult"">
          <xsl:for-each select=""s0:Cuentas"">
            <xsl:for-each select=""s0:Cuenta"">
              <Cuentas>
                <xsl:if test=""s0:SaldoActual"">
                  <SaldoActual>
                    <xsl:value-of select=""s0:SaldoActual/text()"" />
                  </SaldoActual>
                </xsl:if>
                <xsl:if test=""s0:TipoCuenta"">
                  <TipoCuenta>
                    <xsl:value-of select=""s0:TipoCuenta/text()"" />
                  </TipoCuenta>
                </xsl:if>
                <xsl:if test=""s0:activa"">
                  <Activa>
                    <xsl:value-of select=""s0:activa/text()"" />
                  </Activa>
                </xsl:if>
                <xsl:if test=""s0:IdCuenta"">
                  <IdCuenta>
                    <xsl:value-of select=""s0:IdCuenta/text()"" />
                  </IdCuenta>
                </xsl:if>
                <xsl:if test=""s0:NumeroCuenta"">
                  <NumeroDeCuenta>
                    <xsl:value-of select=""s0:NumeroCuenta/text()"" />
                  </NumeroDeCuenta>
                </xsl:if>
              </Cuentas>
            </xsl:for-each>
          </xsl:for-each>
        </xsl:for-each>
      </Cuenta>
    </ns0:CuentaBancariaResp>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"CB.ConsumoWCF.Esquemas.ServiciosBancarios_tempuri_org+ObtenerCuentasPorClienteResponse";
        
        private const global::CB.ConsumoWCF.Esquemas.ServiciosBancarios_tempuri_org.ObtenerCuentasPorClienteResponse _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"CB.ConsumoWCF.Esquemas.CuentaBancariaResp";
        
        private const global::CB.ConsumoWCF.Esquemas.CuentaBancariaResp _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"CB.ConsumoWCF.Esquemas.ServiciosBancarios_tempuri_org+ObtenerCuentasPorClienteResponse";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"CB.ConsumoWCF.Esquemas.CuentaBancariaResp";
                return _TrgSchemas;
            }
        }
    }
}
