<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
  
  <xsl:template match="/">
    <html>
      <h1>Что есть на складе</h1>
      <ul>
        <xsl:for-each select="/items/element">
          <li>
          <xsl:choose>
            <xsl:when test="@color='красный'">
              <xsl:attribute name="style">background-color:#fcc</xsl:attribute>
            </xsl:when>
            <xsl:when test="@color='синий'">
              <xsl:attribute name="style">background-color:#ccf</xsl:attribute>
            </xsl:when>
            <xsl:when test="@color='жолтый'">
              <xsl:attribute name="style">background-color:#ffc</xsl:attribute>
            </xsl:when>
          </xsl:choose>
          <xsl:value-of select="@value"/>
          </li>
        </xsl:for-each>
      </ul>
    </html>
  </xsl:template>
  
</xsl:stylesheet>
