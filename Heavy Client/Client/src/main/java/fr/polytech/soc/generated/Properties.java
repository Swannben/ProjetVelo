
package fr.polytech.soc.generated;

import jakarta.xml.bind.JAXBElement;
import jakarta.xml.bind.annotation.XmlAccessType;
import jakarta.xml.bind.annotation.XmlAccessorType;
import jakarta.xml.bind.annotation.XmlElementRef;
import jakarta.xml.bind.annotation.XmlType;


/**
 * <p>Classe Java pour Properties complex type.
 * 
 * <p>Le fragment de schéma suivant indique le contenu attendu figurant dans cette classe.
 * 
 * <pre>
 * &lt;complexType name="Properties"&gt;
 *   &lt;complexContent&gt;
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType"&gt;
 *       &lt;sequence&gt;
 *         &lt;element name="fare" type="{http://www.w3.org/2001/XMLSchema}int" minOccurs="0"/&gt;
 *         &lt;element name="segments" type="{http://schemas.datacontract.org/2004/07/ProjetVelo}ArrayOfSegment" minOccurs="0"/&gt;
 *         &lt;element name="summary" type="{http://schemas.datacontract.org/2004/07/ProjetVelo}Summary" minOccurs="0"/&gt;
 *         &lt;element name="transfers" type="{http://www.w3.org/2001/XMLSchema}int" minOccurs="0"/&gt;
 *         &lt;element name="way_points" type="{http://schemas.microsoft.com/2003/10/Serialization/Arrays}ArrayOfint" minOccurs="0"/&gt;
 *       &lt;/sequence&gt;
 *     &lt;/restriction&gt;
 *   &lt;/complexContent&gt;
 * &lt;/complexType&gt;
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "Properties", propOrder = {
    "fare",
    "segments",
    "summary",
    "transfers",
    "wayPoints"
})
public class Properties {

    protected Integer fare;
    @XmlElementRef(name = "segments", namespace = "http://schemas.datacontract.org/2004/07/ProjetVelo", type = JAXBElement.class, required = false)
    protected JAXBElement<ArrayOfSegment> segments;
    @XmlElementRef(name = "summary", namespace = "http://schemas.datacontract.org/2004/07/ProjetVelo", type = JAXBElement.class, required = false)
    protected JAXBElement<Summary> summary;
    protected Integer transfers;
    @XmlElementRef(name = "way_points", namespace = "http://schemas.datacontract.org/2004/07/ProjetVelo", type = JAXBElement.class, required = false)
    protected JAXBElement<ArrayOfint> wayPoints;

    /**
     * Obtient la valeur de la propriété fare.
     * 
     * @return
     *     possible object is
     *     {@link Integer }
     *     
     */
    public Integer getFare() {
        return fare;
    }

    /**
     * Définit la valeur de la propriété fare.
     * 
     * @param value
     *     allowed object is
     *     {@link Integer }
     *     
     */
    public void setFare(Integer value) {
        this.fare = value;
    }

    /**
     * Obtient la valeur de la propriété segments.
     * 
     * @return
     *     possible object is
     *     {@link JAXBElement }{@code <}{@link ArrayOfSegment }{@code >}
     *     
     */
    public JAXBElement<ArrayOfSegment> getSegments() {
        return segments;
    }

    /**
     * Définit la valeur de la propriété segments.
     * 
     * @param value
     *     allowed object is
     *     {@link JAXBElement }{@code <}{@link ArrayOfSegment }{@code >}
     *     
     */
    public void setSegments(JAXBElement<ArrayOfSegment> value) {
        this.segments = value;
    }

    /**
     * Obtient la valeur de la propriété summary.
     * 
     * @return
     *     possible object is
     *     {@link JAXBElement }{@code <}{@link Summary }{@code >}
     *     
     */
    public JAXBElement<Summary> getSummary() {
        return summary;
    }

    /**
     * Définit la valeur de la propriété summary.
     * 
     * @param value
     *     allowed object is
     *     {@link JAXBElement }{@code <}{@link Summary }{@code >}
     *     
     */
    public void setSummary(JAXBElement<Summary> value) {
        this.summary = value;
    }

    /**
     * Obtient la valeur de la propriété transfers.
     * 
     * @return
     *     possible object is
     *     {@link Integer }
     *     
     */
    public Integer getTransfers() {
        return transfers;
    }

    /**
     * Définit la valeur de la propriété transfers.
     * 
     * @param value
     *     allowed object is
     *     {@link Integer }
     *     
     */
    public void setTransfers(Integer value) {
        this.transfers = value;
    }

    /**
     * Obtient la valeur de la propriété wayPoints.
     * 
     * @return
     *     possible object is
     *     {@link JAXBElement }{@code <}{@link ArrayOfint }{@code >}
     *     
     */
    public JAXBElement<ArrayOfint> getWayPoints() {
        return wayPoints;
    }

    /**
     * Définit la valeur de la propriété wayPoints.
     * 
     * @param value
     *     allowed object is
     *     {@link JAXBElement }{@code <}{@link ArrayOfint }{@code >}
     *     
     */
    public void setWayPoints(JAXBElement<ArrayOfint> value) {
        this.wayPoints = value;
    }

}
