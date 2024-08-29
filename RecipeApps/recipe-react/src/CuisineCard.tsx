import { ICuisine } from "./DataInterfaces";

interface Props {
  cuisine: ICuisine;
  onSelected: (cuisineid: number) => void;
  isSelected: boolean;
}

export default function CuisineCard({
  cuisine,
  isSelected,
  onSelected,
}: Props) {
  return (
    <>
      <div
        onClick={() => onSelected(cuisine.cuisineID)}
        className={`btn border border-secondary m-2 ${
          isSelected ? "bg-secondary" : ""
        }`}
      >
        <figure className="figure">
          <img
            src={`/img/cuisine-images/${cuisine.cuisineType.toLowerCase()}.jpeg`}
            className="figure-img img-fluid rounded"
            alt="Cuisine Image"
          />
          <figcaption className="figure-caption text-end">
            <h6>{cuisine.cuisineType}</h6>
          </figcaption>
        </figure>
      </div>
    </>
  );
}
