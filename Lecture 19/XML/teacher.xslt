<?xml version="1.0" encoding="UTF-8"?>
<html xsl:version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<body style="font-family:Arial;font-size:12pt;background-color:#EEEEEE">
		<xsl:for-each select="Teachers/Teacher">
			<div style="background-color:teal;color:white;padding:4px">
				<span style="font-weight:bold">
					<xsl:value-of select="EmployeeCode"/> - </span>
				<xsl:value-of select="Name"/>
			</div>
			<div style="margin-left:20px;margin-bottom:1em;font-size:10pt">
				<p>
					<xsl:value-of select="Designation"/>
					<span style="font-style:italic"> (<xsl:value-of select="Salary"/> is taken monthly.)</span>
				</p>
			</div>
		</xsl:for-each>
	</body>
</html>
