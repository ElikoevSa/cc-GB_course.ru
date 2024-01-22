package ru.testapp.classes;

import java.util.Objects;

public class Notebook {

    private int ram;
    private int storageCapacity;
    private String os;
    private String color;
    private String label;


    public Notebook(int ram, int storageCapacity, String os, String color, String label) {
        this.ram = ram;
        this.storageCapacity = storageCapacity;
        this.os = os;
        this.color = color;
        this.label = label;
    }

    public int getRam() {
        return ram;
    }

    public void setRam(int ram) {
        this.ram = ram;
    }

    public int getStorageCapacity() {
        return storageCapacity;
    }

    public void setStorageCapacity(int storageCapacity) {
        this.storageCapacity = storageCapacity;
    }

    public String getOs() {
        return os;
    }

    public void setOs(String os) {
        this.os = os;
    }

    public String getColor() {
        return color;
    }

    public void setColor(String color) {
        this.color = color;
    }

    public String getLabel() {
        return label;
    }

    public void setLabel(String label) {
        this.label = label;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (!(o instanceof Notebook notebook)) return false;
        return getRam() == notebook.getRam() && getStorageCapacity() == notebook.getStorageCapacity() && Objects.equals(getOs(), notebook.getOs()) && Objects.equals(getColor(), notebook.getColor()) && Objects.equals(getLabel(), notebook.getLabel());
    }

    @Override
    public int hashCode() {
        return Objects.hash(getRam(), getStorageCapacity(), getOs(), getColor(), getLabel());
    }

    @Override
    public String toString() {
        return "Notebook {\n" +
                " Ram : "  + ram +
                " GB\n storageCapacity : " + storageCapacity +
                " GB\n os: " + os + '\n' +
                " Color : " + color + '\n' +
                " Label : " + label + '\n' +
                '}';
    }
}
