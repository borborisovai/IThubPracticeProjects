<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
  
  <xsl:template match="/">
    <html>
      <h1>Что есть на складе</h1>
      <ul>
        <xsl:apply-templates select="/items/element"/>
      </ul>
    </html>
  </xsl:template>

  <xsl:template match="element">
    <li>
      <xsl:value-of select="@value"/>
      <xsl:if test="@onstore = 'yes'">
        НА СКЛАДЕ
      </xsl:if>
    </li>
  </xsl:template>
</xsl:stylesheet>
