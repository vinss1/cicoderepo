#!/usr/bin/env groovy
 
@Library('SharedciLibMaster') _
	pipeline {
		agent any
		stages {
			stage('Testing') {
				steps {
					script {
						EnvVars envVars = build.getEnvironment(listener);
						def filename = envVars.get('WORKSPACE')
						echo "Workspace: ${filename}"
					}
				}
			}
			stage('Scan for new jobs') {
				steps {
					echo 'Scanning...'
					echo "${pwd()}"
					echo "${WORKSPACE}"
					script {
						bat 'set > env.txt'
						String[] envs = readFile('env.txt').split("\r?\n")
						for(String vars: envs){
							println(vars)
						}
					}
					
				}
			}

			stage('Build jobs') {
				steps {
					echo pipelineParams.message
					
				}
			}
		}
	}
