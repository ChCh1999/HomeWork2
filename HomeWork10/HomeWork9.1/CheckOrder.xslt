<?xml version="1.0"?>
<xsl:stylesheet version="1.0"
xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

  <xsl:template match="/">
    <html>
      <body>
        <h2>AllOrder</h2>
        <xsl:for-each select="ArrayOfOrder/Order">

          <p>
            订单号：<xsl:value-of select="OrderNum"/>
          </p>
          <p>
            顾客：<xsl:value-of select="Customer"/>
          </p>
          <p>
            电话：<xsl:value-of select="TelNum"/>
          </p>
          <p>
            总值：<xsl:value-of select="Money"/>
          </p>
          <table border="1">
            <tr bgcolor="#9acd32">
              <th>Type</th>
              <th>Price</th>
              <th>Amount</th>
              <th>Money</th>
            </tr>
            <tr>
              <xsl:for-each select="ListOfProduct/OrderDetails">
                <td>
                  <xsl:value-of select="TypeOfProduct"/>
                </td>
                <td>
                  <xsl:value-of select="PriceOfProduct"/>
                </td>
                <td>
                  <xsl:value-of select="AmountOfProduct"/>
                </td>
                <td>
                  <xsl:value-of select="PriceOfProduct"/>
                </td>
              </xsl:for-each>
            </tr>
          </table>


        </xsl:for-each>
      </body>
    </html>
  </xsl:template>

</xsl:stylesheet>