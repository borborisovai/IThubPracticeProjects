<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output method="xml" indent="yes" encoding="UTF-8"/>
    
    <xsl:template match="/">
        <items>
            <xsl:apply-templates select="//li"/>
        </items>
    </xsl:template>

    <xsl:template match="li">

        <xsl:variable name="parentid">
            <xsl:choose>
                <xsl:when test="ancestor::li[1]">
                    <xsl:value-of select="ancestor::li[1]/@data-id"/>
                </xsl:when>
                <xsl:otherwise>0</xsl:otherwise>
            </xsl:choose>
        </xsl:variable>
    
        <item id="{@data-id}" parentid="{$parentid}" author="{normalize-space(b)}">
            <xsl:value-of select="normalize-space(span)"/>
        </item>
    
        <xsl:apply-templates select=".//li[ancestor::li[1] = current()]"/>
    </xsl:template>
</xsl:stylesheet>