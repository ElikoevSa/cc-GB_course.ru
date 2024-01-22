package ru.testapp.enums;

public enum NotebookLabels {
    NOTEBOOK_LABELS_ACER("Acer"),
    NOTEBOOK_LABELS_ASUS("Asus"),
    NOTEBOOK_LABELS_LENOVO("Lenovo");
    private String name;

    NotebookLabels(String name) {
        this.name = name;
    }

    public String getName() {
        return name;
    }

    public static StringBuilder getLabelNames(){
        return new StringBuilder("1. " +NOTEBOOK_LABELS_ASUS.getName()+"\n"+
                "2. " +NOTEBOOK_LABELS_LENOVO.getName()+"\n"+
                "3. " +NOTEBOOK_LABELS_ACER.getName()+"\n");
    }

    @Override
    public String toString() {
        return "NotebookLabels{" +
                "name='" + name + '\'' +
                '}';
    }
}
