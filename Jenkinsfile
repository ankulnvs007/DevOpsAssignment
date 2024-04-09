pipeline {
  agent any
  stages{
    stage('checkout'){
    steps{
      git url: 'https://github.com/ankulnvs007/DevOpsAssignment.git' , branch: 'master'
    }
  }

stage('build'){
    steps{
      sh 'dotnet build'
    }
  }

stage('test'){
    steps{
      sh 'dotnet test'
    }
  }
}
}
