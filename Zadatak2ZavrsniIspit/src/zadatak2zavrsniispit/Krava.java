/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package zadatak2zavrsniispit;

/**
 *
 * @author office
 */
public class Krava {

    public Krava(int id, String ime) {
        this.id = id;
        this.ime = ime;
    }
    
    /**
     * @return the id
     */
    public int getId() {
        return id;
    }

    /**
     * @return the ime
     */
    public String getIme() {
        return ime;
    }

    /**
     * @param ime the ime to set
     */
    public void setIme(String ime) {
        this.ime = ime;
    }
    private int id;
    private String ime;

    @Override
    public String toString() {
        return String.format("%d %s", id, ime);
    }
    
    
}
