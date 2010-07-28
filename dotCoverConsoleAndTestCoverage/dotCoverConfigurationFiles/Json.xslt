<?xml version="1.0" encoding="ISO-8859-1"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

  <xsl:template match="Root/Assembly">
    [      <xsl:for-each select="Namespace">
     {"Namespace": "<xsl:value-of select="@Name"/>",
      "CoveredPercentage": "<xsl:value-of select="@CoveragePercent"/>%",
      "CoveredStatements": "<xsl:value-of select="@CoveredStatements"/>",
      "TotalStatements": "<xsl:value-of select="@TotalStatements"/>"
      <xsl:variable name="types" select="Type"/>
      <xsl:if test="$types">
      , "Classes": [
      <xsl:for-each select="Type">
        <xsl:if test="position() > 1">,</xsl:if>
        {"Class": "<xsl:value-of select="@Name"/>",
                 "CoveredPercentage": "<xsl:value-of select="@CoveragePercent"/>%",
                "CoveredStatements": "<xsl:value-of select="@CoveredStatements"/>",
                "TotalStatements": "<xsl:value-of select="@TotalStatements"/>"
        <xsl:variable name="members" select="Member"/>
        <xsl:if test="$members">
          ,"Methods": [
          <xsl:for-each select="Member">
            
            <xsl:if test="position() > 1">,
          </xsl:if>
          { "Method": "<xsl:value-of select="@Name"/>",
            "CoveredPercentage": "<xsl:value-of select="@CoveragePercent"/>%",
            "CoveredStatements": "<xsl:value-of select="@CoveredStatements"/>",
            "TotalStatements": "<xsl:value-of select="@TotalStatements"/>"
            }
          </xsl:for-each>]
        </xsl:if>
        }

      </xsl:for-each>]
      </xsl:if>
      }
   <xsl:if test="position() > 1">,</xsl:if>
          </xsl:for-each>
      ]
  </xsl:template>
</xsl:stylesheet>

