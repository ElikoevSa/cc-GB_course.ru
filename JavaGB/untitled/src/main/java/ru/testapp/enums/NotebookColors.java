package ru.testapp.enums;

public enum NotebookColors {
     NOTEBOOK_COLORS_RED("Red"),
    NOTEBOOK_COLORS_BLUE("Blue"),
    NOTEBOOK_COLORS_SILVER("Silver"),
    NOTEBOOK_COLORS_BLACK("Black")
    ;

    private String color;

    NotebookColors(String color) {
        this.color = color;
    }

    public String getColor() {
        return color;
    }

    public static StringBuilder getColorNotebook(){
        return new StringBuilder("1. " +NOTEBOOK_COLORS_RED.getColor()+"\n"+
                "2. " +NOTEBOOK_COLORS_BLUE.getColor()+"\n"+
                "3. " +NOTEBOOK_COLORS_SILVER.getColor()+"\n"+
                "4. " +NOTEBOOK_COLORS_BLACK.getColor()+"\n");
    }

    @Override
    public String toString() {
        return "NotebookColors{" +
                "color='" + color + '\'' +
                '}';
    }
}
