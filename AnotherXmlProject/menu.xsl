<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">

  <xsl:output method="xml" encoding="utf-8"/>  
  
  <xsl:template match="/">
    <html>
      <h1>Пример навигационного меню</h1>
      <ul>
        <xsl:apply-templates select="menu/menuItem"/>
      </ul>
    </html>  
  </xsl:template>
  
  <xsl:template match="menuItem">
    <li>
      <a href="{@link}"><xsl:value-of select="@title"/></a>
      <xsl:if test="./menuItem">
        <ul>
          <xsl:apply-templates select="./menuItem"/>
        </ul>
      </xsl:if>
    </li>
  </xsl:template>  
  
</xsl:stylesheet>
