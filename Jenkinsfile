pipeline {
  agent any
  stages('checkout'){
    steps{
      git url: 'https://github.com/ankulnvs007/DevOpsAssignment.git' , branch: 'master'
    }
  }

stages('build'){
    steps{
      sh 'dotnet build'
    }
  }

stages('test'){
    steps{
      sh 'dotnet test'
    }
  }
}
