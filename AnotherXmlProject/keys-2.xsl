<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
  
  <xsl:key name="ixPrice" match="/pricelist/book" use="./price"/>
  <xsl:key name="ixPrice2" match="/pricelist/book/price" use="."/>
  
  <xsl:key name="ixBook" match="/pricelist/book" use="price"/>
  <xsl:key name="ixBook" match="/pricelist/book" use="author"/>
  
  <xsl:template match="/">
    <html>
      <h1>
        Книжек за 250 руб.
        <xsl:value-of select="count(key('ixPrice', 250))"/>
        штук
      </h1>
      <ul>
        <xsl:apply-templates select="key('ixBook', 250)"/>
      </ul>
      Всего: <xsl:value-of select="sum(key('ixPrice2', 250))"/>
      <ul>
        <xsl:apply-templates select="key('ixBook', 'Алекс Гомер')"/>
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
