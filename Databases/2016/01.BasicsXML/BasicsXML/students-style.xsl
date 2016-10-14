<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:d="urn:students">
  <xsl:template match="/">
    <html>
      <body>
        <h1>Students</h1>
        <ul>
          <xsl:for-each select="/d:school/d:student">
            <li>
              <h3>
                <xsl:value-of select="d:name" />
              </h3>
              <div>
                Faculty Number - <xsl:value-of select="d:faculty_number" />
              </div>
              <div>
                Course - <xsl:value-of select="d:course" />
              </div>
              <div>
                Gender - <xsl:value-of select="d:gender" />
              </div>
              <div>
                Birth date - <xsl:value-of select="d:birthdate" />
              </div>
              <div>
                Phone - <xsl:value-of select="d:phone" />
              </div>
              <div>
                email - <xsl:value-of select="d:email" />
              </div>
              <div>
                Specialty - <xsl:value-of select="d:specialty" />
              </div>
              <h4>
                Exams
              </h4>
              <xsl:for-each select=".//d:exam">
                <div>
                  Exam - <xsl:value-of select="d:exam_name" />
                </div>
                <div>
                  Exam Sore - <xsl:value-of select="d:score" />
                </div>
              </xsl:for-each>
            </li>
          </xsl:for-each>
        </ul>      
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>
