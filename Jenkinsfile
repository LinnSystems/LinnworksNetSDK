node {
	stage 'Checkout'
		checkout scm

	stage 'Build'
		bat "\"${tool 'MSBuild'}\" "./Linnworks/src/net/LinnworksSDK.sln" /p:Configuration=Release /p:Platform=\"Any CPU\" /p:ProductVersion=3.0.0.${env.BUILD_NUMBER}"

	stage 'Archive'
		archive 'ProjectName/bin/Release/**'

}