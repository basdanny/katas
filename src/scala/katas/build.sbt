lazy val root = (project in file(".")).
  settings(
    inThisBuild(List(
      organization := "com.katas",
      scalaVersion := "3.5.2"
    )),
    name := "katas"
  )

libraryDependencies += "org.scalatest" %% "scalatest" % "3.2.19" % Test
