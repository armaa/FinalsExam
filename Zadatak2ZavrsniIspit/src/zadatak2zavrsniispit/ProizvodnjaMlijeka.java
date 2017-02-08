/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package zadatak2zavrsniispit;

import java.util.Date;

/**
 *
 * @author office
 */
public class ProizvodnjaMlijeka {

    public ProizvodnjaMlijeka(int id, int idkrava, Date datumUzimanja, double kolicina) {
        this.id = id;
        this.idkrava = idkrava;
        this.datumUzimanja = datumUzimanja;
        this.kolicina = kolicina;
    }
    
    /**
     * @return the id
     */
    public int getId() {
        return id;
    }

    /**
     * @return the idkrava
     */
    public int getIdkrava() {
        return idkrava;
    }

    /**
     * @return the datumUzimanja
     */
    public Date getDatumUzimanja() {
        return datumUzimanja;
    }

    /**
     * @return the kolicina
     */
    public double getKolicina() {
        return kolicina;
    }
    private int id;
    private int idkrava;
    private Date datumUzimanja;
    private double kolicina;
}
