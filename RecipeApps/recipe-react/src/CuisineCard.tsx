import { ICuisine } from "./DataInterfaces";

interface Props {
  cuisine: ICuisine;
}
export default function CuisineCard({ cuisine }: Props) {
  return (
    <>
      {/* <div
        onClick={() => onSelected(party.partyId)}
        className={`btn ${isSelected ? "bg-secondary" : ""}`}
      > */}
      <figure className="figure">
        <img
          src={`/img/cuisine-images/${cuisine.cuisineType.toLowerCase()}.jpeg`}
          className="figure-img img-fluid rounded"
          alt="Cuisine Image"
        />
        <figcaption className="figure-caption text-end">
          {cuisine.cuisineType}
        </figcaption>
      </figure>
      {/* </div> */}
    </>
  );
}
