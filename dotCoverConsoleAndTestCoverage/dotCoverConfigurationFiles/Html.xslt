<?xml version="1.0" encoding="ISO-8859-1"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

  <xsl:template match="Root/Assembly">
    <html>
      <head>
        <title>dotCover Coverage Results</title>
        <link rel="stylesheet" href="StyleSheet.css"/>
      </head>
      <body>
        <h2>dotCover Coverage Results</h2>
        <br/>
        <xsl:for-each select="Namespace">
          <div id="namespace">
            <div class="name">
              <xsl:variable name="namespace_bookmark" select="@Name"/>
              <a>
                <xsl:attribute name="href">
                  <xsl:value-of select="$namespace_bookmark"/>
                </xsl:attribute>
                <xsl:value-of select="$namespace_bookmark"/>
              </a>
            </div>
            <div class="total_statements">
              <xsl:value-of select="@TotalStatements"/> 
            </div>
            <div class="covered_statements">
              <xsl:value-of select="@CoveredStatements"/> 
            </div>
            <div class="covered_percentage">
              <xsl:value-of select="@CoveragePercent"/> %
            </div>
            <br/>
          </div>
          <br/>
          <xsl:for-each select="Type">
            <xsl:variable name="type_bookmark" select="@Name"/>
            <div id="type">
              <div class="name">
                
              <a>
                <xsl:attribute name="href">
                  <xsl:value-of select="$type_bookmark"/>
                </xsl:attribute>
                <xsl:value-of select="$type_bookmark"/>
              </a>
              </div>
              <div class="total_statements">
                <xsl:value-of select="@TotalStatements"/>
              </div>
              <div class="covered_statements">
                <xsl:value-of select="@CoveredStatements"/>
              </div>
              <div class="covered_percentage">
                <xsl:value-of select="@CoveragePercent"/> %
              </div>
              <br/>
 
            </div>
            <br/>
            <xsl:for-each select="Member">
              <xsl:variable name="member_bookmark" select="@Name"/>
              <div id="member">
                <div class="name">
                  
                <a>
                  <xsl:attribute name="href">
                    <xsl:value-of select="$member_bookmark"/>
                  </xsl:attribute>
                  <xsl:value-of select="$member_bookmark"/>
                </a>
                </div>
                <div class="total_statements">
                  <xsl:value-of select="@TotalStatements"/>
                </div>
                <div class="covered_statements">
                  <xsl:value-of select="@CoveredStatements"/>
                </div>
                <div class="covered_percentage">
                  <xsl:value-of select="@CoveragePercent"/> %
                </div>
                <br/>
              </div>

            </xsl:for-each>
            <br/>
          </xsl:for-each>
        </xsl:for-each>
        <br/>
        <br/>
        <p>
          <p>
            <h3>Legend</h3>
            <table>
              <tr>
                <td class="legend_total_statements">.....</td>
                <td>Total Statements</td>
              </tr>
              <tr>
                <td class="legend_covered_statements">.....</td>
                <td>Covered Statements</td>
              </tr>
              <tr>
                <td class="legend_covered_percentage">.....</td>
                <td>Covered Percentage</td>
              </tr>
              
            </table>
          </p>
        </p>
      </body>

    </html>

  </xsl:template>
</xsl:stylesheet>

