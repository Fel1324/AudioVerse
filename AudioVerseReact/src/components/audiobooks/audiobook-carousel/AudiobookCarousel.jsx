import { ChevronLeft } from "../../icons/ChevronLeft.jsx";
import { ChevronRight } from "../../icons/ChevronRight.jsx";

export function AudiobookCarousel(){
    return(
        <section>
            <div>
                <div>
                    <h2>Terminar</h2>
                    <div>
                        <button>
                            <ChevronLeft />
                        </button>

                        <button>
                            <ChevronRight />
                        </button>
                    </div>
                </div>
            </div>
        </section>
    )
}
