<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
  
  <xsl:template match="/">
    <html>
      <ul>
        <xsl:apply-templates select="/pricelist/book">
          <xsl:sort select="author"/>
        </xsl:apply-templates>
      </ul>
    </html>
  </xsl:template>

  <xsl:template match="book">
    <li>
      <xsl:for-each select="*">
        <xsl:value-of select="name()"/>
        <xsl:text>: </xsl:text>
        <xsl:value-of select="."/>
        <xsl:text> </xsl:text>
      </xsl:for-each>
    </li>
  </xsl:template>

</xsl:stylesheet>
