package ru.testapp.enums;

public enum NotebookOSNames {
   UBUNTU_20_04("Ubuntu 20.04"),
   CENTOS_7("Centos 7"),
   WINDOWS("Windows 10");

   private String name;

   NotebookOSNames(String name) {
      this.name = name;
   }

   public String getName() {
      return name;
   }

   public static StringBuilder getOSNames(){
      return new StringBuilder("1. " +UBUNTU_20_04.getName()+"\n"+
              "2. " +CENTOS_7.getName()+"\n"+
              "3. " +WINDOWS.getName()+"\n");
   }

   @Override
   public String toString() {
      return "Osnames{" +
              "name='" + name + '\'' +
              '}';
   }
}
