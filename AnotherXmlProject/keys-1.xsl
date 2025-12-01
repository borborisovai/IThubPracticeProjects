<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
  
  <xsl:key name="ixBook" match="/pricelist/book" use="price"/>
  
  <xsl:template match="/">
    <html>
      <h1>
        Книжек за 250 руб.
        <xsl:value-of select="count(key('ixBook', 250))"/>
        штук
      </h1>
      <ul>
        <xsl:apply-templates select="key('ixBook', 250)"/>
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
